using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;
using System.IO;
using System.IO.Ports;
using System.Threading;
using ZedGraph;


namespace FanControl
{
    public partial class Form1 : Form
    {
        //Needed to capture mouse click and drag on title bar and drag window. 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //Serial Port declarations
        public static SerialPort ComPort = new SerialPort();
        private char SerialChar;
        private String SerialData = "";
        public String[] SerialWords;
        public static string SerialSend = "";

        //Log file declarations
        public StreamWriter sw;

        //Declarations used for OpenHardware Monitor
        private Computer computer = new Computer();
        private UpdateVisitor updateVisitor = new UpdateVisitor();

        //Declarations for delegates to update UI from various threads. 
        public delegate void UpdateLabel(string label);
        public delegate void UpdateAlarms();
        public delegate void UpdateFans();
        public delegate void UpdateForm2(string label);

        //Variables for storing current values
        private double[] CPU_Temp = new double[3];
        private double VRM_Temp;
        private double CPU_Temp_avg;
        private double CPU_Perc;
        private double GPU_Temp;
        private double GPU_Perc;
        private double SYS_Temp;
        private double CASEB_Temp;
        private double CASET_Temp;
        private double CASET_Fan;
        private double RAD_Temp;
        private double RAD_Fan;
        private double AON_Fan;
        private double FLOW;
        
        //Variables for storing alarms.
        private double VRM_Temp_alarm = 0;
        private double CPU_Temp_alarm = 0;
        private double GPU_Temp_alarm = 0;
        private double SYS_Temp_alarm = 0;
        private double CASEB_Temp_alarm = 0;
        private double CASET_Temp_alarm = 0;
        private double RAD_Temp_alarm = 0;
        private double FLOW_alarm = 0;

        //Variables for storing Fan conditions
        private double Fan1LowT;
        private double Fan1LowO;
        private double Fan1HighT;
        private double Fan1HighO;
        private double Fan1Hys;
        private double Fan2LowT;
        private double Fan2LowO;
        private double Fan2HighT;
        private double Fan2HighO;
        private double Fan2Hys;
        private double Fan3LowT;
        private double Fan3LowO;
        private double Fan3HighT;
        private double Fan3HighO;
        private double Fan3Hys;
        private double Iface;

        //Standard colours used in UI
        private Color cMainBack = Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
        private Color cSidebarBack = Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
        private Color cButtonBack = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
        private Color cButtonBorder = Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
        private Color cShadeLight = Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
        private Color cTextDark = Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
        private Color cAccentG = Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(184)))), ((int)(((byte)(192)))));
        private Color cAccentB = Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(163)))), ((int)(((byte)(251)))));
        private Color cAccentP = Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(106)))), ((int)(((byte)(175)))));

        //Declarations for the Status window graph and the fan graph. 
        PointPairList Fan1PointPair = new PointPairList();
        PointPairList Fan2PointPair = new PointPairList();
        PointPairList Fan3PointPair = new PointPairList();
        PointPairList FanTPointPair = new PointPairList();
        PointPairList TempWaterPointPair = new PointPairList();
        PointPairList TempCPUPointPair = new PointPairList();
        PointPairList TempGPUPointPair = new PointPairList();
        GraphPane myPane, myPane2;
        MasterPane myMasterpane, myMasterpane2;
        LineItem Fan1Curve, Fan2Curve, Fan3Curve, FanTCurve;
        LineItem TempWaterCurve, TempCPUCurve, TempGPUCurve;
        private static int history_length = 900;
        public double[] HistoryWater = new double[history_length];
        public double[] HistoryCPU = new double[history_length];
        public double[] HistoryGPU = new double[history_length];
        
        private bool first_run = true;

        private int averager = 0;

        //Temp File is used by rainmeter.
        private string temp_file = Environment.ExpandEnvironmentVariables("%TEMP%")+"\\Fanctl.tmp";
                       
        /*
         * Open the Serial port and and update the button colours. Additionally send the H:; Hello command which 
         * causes the controller to reply with current alarm settings, and the F:; Fan settings command which 
         * causes the controller to reply with the current fan settings. 
         */
        private void Connect()
        {
            bool error = false;
            
            if (cmbPortName.SelectedIndex != -1)
            {  
                ComPort.PortName = cmbPortName.Text;
                ComPort.BaudRate = 115200; 
                ComPort.Parity = Parity.None;
                ComPort.DataBits = 8;
                ComPort.StopBits = StopBits.One;
                ComPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(ComPort_DataReceived);
                SerialData = "";
                try 
                {
                ComPort.Open();
                }
                    catch (UnauthorizedAccessException) { error = true; }
                    catch (System.IO.IOException) { error = true; }
                    catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Could not open the COM port. Most likely it is already in use, has been removed, or is unavailable.", "COM Port unavailable", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Please select all the COM Serial Port Settings", "Serial Port Interface", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (ComPort.IsOpen)
            {
                btnConnect.Text = "Disconnect";
                btnConnect2.Text = "CONNECTED";
                btnConnect2.BackColor = Color.White;
                btnConnect2.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(164)))), ((int)(((byte)(29)))));
                btnConnect2.ForeColor = Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(164)))), ((int)(((byte)(29)))));
                ComPort.Write("H:;\n");
                ComPort.Write("F:;\n");
            }
        }

        /*
         * Close the Serial port and update the button colours. Additionally write -- into the temp_file
         * so that rainmeter will not show stuck values on the desktop. 
         */
        private void Disconnect()
        {
            ComPort.Close();
            SerialData = "";
            btnConnect.Text = "Connect";
            btnConnect2.Text = "DISCONNECTED";
            btnConnect2.BackColor = Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            btnConnect2.FlatAppearance.BorderColor = Color.Maroon;
            btnConnect2.ForeColor = Color.White;
            System.IO.StreamWriter objWriter = new System.IO.StreamWriter(temp_file);
            objWriter.Write("--");
            objWriter.Close();
        }

        /*
         * Main Form1 constructor. Reads the com ports on the system, starts the event timer, and initialises
         * open hardware monitor
         */
        public Form1()
        {
            InitializeComponent();
            updatePorts();
            tmrUpdate.Enabled = true;

            computer.Open();
            computer.CPUEnabled = true;
            computer.GPUEnabled = true;
            computer.MainboardEnabled = true;
        }

        /*
         * Check which serial ports are available on the system
         */
        private void updatePorts()
        {
            cmbPortName.Text = "COM Port";
            cmbPortName.Items.Clear();

            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                foreach (string port in ports)
                {
                    cmbPortName.Items.Add(port);
                }
                cmbPortName.SelectedIndex = 0;
            }
        }

        /*
         * Update visitor for reading computer data
         */
        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }
            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }

        /*
         * This routine reads the current computer information and saves it to variables. The individual
         * sensors which are read are hard coded. This could be improved.
         * CPU Sensor 19: Junction temp of of AMD 2700X
         * CPU Sensor 16: Total load of CPU
         * GPU Sensor 0: GPU Temperature
         * GPU Sensor 5: Total load of GPU
         * Mainboard Sensor 6: VRM Temperature
         * Mainboard Sensor 2: PCH Temperature 
         *  
         * This needs to be updated for each individual machine. This can best be done by running the
         * program with a breakline at each if statement and then drilling down the array to see which
         * element you wish to reference. 
         */
        public void GetSystemInfo(int index)
        {
            computer.Accept(updateVisitor);
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                try
                {
                    if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                    {
                        if (computer.Hardware[i].Sensors[19].SensorType == SensorType.Temperature)
                        {
                            CPU_Temp[index] = Math.Round((double)computer.Hardware[i].Sensors[19].Value);
                        }
                        if (computer.Hardware[i].Sensors[16].SensorType == SensorType.Load)
                        {
                            CPU_Perc = Math.Round((double)computer.Hardware[i].Sensors[16].Value);
                        }
                    }
                    else if (computer.Hardware[i].HardwareType == HardwareType.GpuNvidia)
                    {
                        if (computer.Hardware[i].Sensors[0].SensorType == SensorType.Temperature)
                        {
                            GPU_Temp = (double)computer.Hardware[i].Sensors[0].Value;
                        }
                        if (computer.Hardware[i].Sensors[5].SensorType == SensorType.Load)
                        {
                            GPU_Perc = Math.Round((double)computer.Hardware[i].Sensors[5].Value);
                        }
                    }
                    else if (computer.Hardware[i].HardwareType == HardwareType.Mainboard)
                    {

                        if (computer.Hardware[i].SubHardware[0].Sensors[6].SensorType == SensorType.Temperature)
                        {
                            VRM_Temp = (double)computer.Hardware[i].SubHardware[0].Sensors[6].Value;
                        }
                        if (computer.Hardware[i].SubHardware[0].Sensors[2].SensorType == SensorType.Temperature)
                        {
                            SYS_Temp = (double)computer.Hardware[i].SubHardware[0].Sensors[2].Value;
                        }
                    }
                }
                catch (Exception e)
                {
                    CPU_Temp[index] = 10;
                    GPU_Temp = 10;
                    VRM_Temp = 10;
                    SYS_Temp = 00;
                    Console.WriteLine(e);
                }
            }
        }

        /*
         * tmrUpdate executes every second to read the current system settings. Then it invokes
         * a background worker to update the UI. Finally it also breaks down SerialWords into 
         * the correct variables.
         */

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            GetSystemInfo(averager);
            if (averager >= 2)
            {
                //Invoke Background worker to update display
                backgroundWorkerUI.RunWorkerAsync();
                averager = 0;

                if (ComPort.IsOpen)
                {
                    System.IO.StreamWriter objWriter = new System.IO.StreamWriter(temp_file);
                    objWriter.Write(
                        RAD_Temp.ToString("00.0") + ":" +
                        FLOW.ToString() + ":" +
                        CASEB_Temp.ToString("00.0") + ":" +
                        CASET_Temp.ToString("00.0") + ":" +
                        RAD_Fan.ToString() + ":" +
                        CASET_Fan.ToString() + ":" +
                        AON_Fan.ToString() + ":" +
                        CPU_Temp_avg.ToString() + ":" +
                        GPU_Temp.ToString());
                    objWriter.Close();
                }

                if (SerialWords.Length > 6)
                {
                    try
                    {
                        CASEB_Temp = (Convert.ToDouble(SerialWords[1])) / 10;
                        CASET_Temp = (Convert.ToDouble(SerialWords[2])) / 10;
                        CASET_Fan = Convert.ToDouble(SerialWords[3]);
                        RAD_Temp = (Convert.ToDouble(SerialWords[4])) / 10;
                        RAD_Fan = Convert.ToDouble(SerialWords[5]);
                        AON_Fan = Convert.ToDouble(SerialWords[6]);
                        FLOW = Convert.ToDouble(SerialWords[7]);
                    }
                    catch (System.FormatException ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }

            }
            else
            {
                averager++;
            }

            if (first_run == true && cmbPortName.SelectedIndex != -1)
            {
                first_run = false;
                Connect();
            }
            if (sw != null)
            {
                /*Streamwriter is availablle, log to file*/
                sw.WriteLine(
                    DateTime.Now + "," +
                    RAD_Temp.ToString("00.0") + "," +
                    FLOW.ToString() + "," +
                    CASEB_Temp.ToString("00.0") + "," +
                    CASET_Temp.ToString("00.0") + "," +
                    RAD_Fan.ToString() + "," +
                    CASET_Fan.ToString() + "," +
                    AON_Fan.ToString() + "," +

                    VRM_Temp.ToString() + "," +
                    CPU_Temp_avg.ToString() + "," +
                    CPU_Perc.ToString() + "," +
                    GPU_Temp.ToString() + "," +
                    GPU_Perc.ToString() + "," + 
                    SYS_Temp.ToString());
            }

            /* Draw graphs */
            for (int i=history_length-1; i>0; i--)
            {
                HistoryWater[i] = HistoryWater[i-1];
                HistoryCPU[i] = HistoryCPU[i-1];
                HistoryGPU[i] = HistoryGPU[i-1];
            }
            HistoryWater[0] = RAD_Temp;
            HistoryCPU[0] = CPU_Temp_avg;
            HistoryGPU[0] = GPU_Temp;
        }

        /*
         * Event handler for connect button.
         */
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                Disconnect();
            }
            else
            {
                Connect();
            }
        }

        /* 
         * This causes the main window to minimise to the system tray rather than the
         * task bar.
         */
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        /*
         * Clicking the tray icon causes Form1 to display again. Currently there is no
         * right click context menu on the taskbar. This could be improved.
         */
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.Activate();
            this.WindowState = FormWindowState.Normal;
            this.Focus();
        }
           
        /*
         * When data is received on the COM port ad it to the Character Array. If the character is
         * ';' then process the command. It splits by :, checkes the "command" value and then splits
         * the data into values accordingly. Finally it invokes a display update. 
         */
        private void ComPort_DataReceived(object sender, SerialDataReceivedEventArgs e) 
        {
            while (ComPort.BytesToRead > 0)
            {
                SerialChar = (char)ComPort.ReadChar();
                
                if (SerialChar == ';')
                {
                    SerialWords = SerialData.Split(':');
                    SerialWords[0] = SerialWords[0][SerialWords[0].Length-1].ToString();

                    if (SerialWords[0].Contains("V") && SerialWords.Length == 8)
                    {
                        CASEB_Temp = (Convert.ToDouble(SerialWords[1])) / 10;
                        CASET_Temp = (Convert.ToDouble(SerialWords[2])) / 10;
                        CASET_Fan = Convert.ToDouble(SerialWords[3]);
                        RAD_Temp = (Convert.ToDouble(SerialWords[4])) / 10;
                        RAD_Fan = Convert.ToDouble(SerialWords[5]);
                        AON_Fan = Convert.ToDouble(SerialWords[6]);
                        FLOW = Convert.ToDouble(SerialWords[7]);
                    }
                    else if (SerialWords[0].Contains("A") && SerialWords.Length == 14)
                    {
                        VRM_Temp_alarm = Convert.ToDouble(SerialWords[1]);
                        CPU_Temp_alarm = Convert.ToDouble(SerialWords[2]);
                        GPU_Temp_alarm = Convert.ToDouble(SerialWords[4]);
                        SYS_Temp_alarm = Convert.ToDouble(SerialWords[6]);
                        CASEB_Temp_alarm = Convert.ToDouble(SerialWords[7]);
                        CASET_Temp_alarm = Convert.ToDouble(SerialWords[8]);
                        RAD_Temp_alarm = Convert.ToDouble(SerialWords[10]);
                        FLOW_alarm = Convert.ToDouble(SerialWords[13]);
                        this.Invoke(new UpdateAlarms(UpdateUiAlarms));
                    }
                    else if (SerialWords[0].Contains("F") && SerialWords.Length == 17)
                    {
                        Fan1LowT = Convert.ToDouble(SerialWords[1]);
                        Fan1LowO = Convert.ToDouble(SerialWords[2]);
                        Fan1HighT = Convert.ToDouble(SerialWords[3]);
                        Fan1HighO = Convert.ToDouble(SerialWords[4]);
                        Fan1Hys = Convert.ToDouble(SerialWords[5]);
                        Fan2LowT = Convert.ToDouble(SerialWords[6]);
                        Fan2LowO = Convert.ToDouble(SerialWords[7]);
                        Fan2HighT = Convert.ToDouble(SerialWords[8]);
                        Fan2HighO = Convert.ToDouble(SerialWords[9]);
                        Fan2Hys = Convert.ToDouble(SerialWords[10]);
                        Fan3LowT = Convert.ToDouble(SerialWords[11]);
                        Fan3LowO = Convert.ToDouble(SerialWords[12]);
                        Fan3HighT = Convert.ToDouble(SerialWords[13]);
                        Fan3HighO = Convert.ToDouble(SerialWords[14]);
                        Fan3Hys = Convert.ToDouble(SerialWords[15]);
                        Iface = Convert.ToDouble(SerialWords[16]);
                        this.Invoke(new UpdateFans(UpdateUiFan));
                    }

                    this.Invoke(new UpdateLabel(UpdateUIRecv), SerialData);
                    SerialData = "";

                } else if (SerialChar != '\n' && SerialChar != '\r')
                {
                    SerialData += SerialChar;
                }
            }
        }


        /*
         * Procedure to update all values on the fan page except the graph.
         */
        public void UpdateUiFan()
        {
            txtFan1LowT.Text = Fan1LowT.ToString();
            txtFan1LowO.Text = Fan1LowO.ToString();
            txtFan1HighT.Text = Fan1HighT.ToString();
            txtFan1HighO.Text = Fan1HighO.ToString();
            txtFan1Hys.Text = Fan1Hys.ToString();
            txtFan2LowT.Text = Fan2LowT.ToString();
            txtFan2LowO.Text = Fan2LowO.ToString();
            txtFan2HighT.Text = Fan2HighT.ToString();
            txtFan2HighO.Text = Fan2HighO.ToString();
            txtFan2Hys.Text = Fan2Hys.ToString();
            txtFan3LowT.Text = Fan3LowT.ToString();
            txtFan3LowO.Text = Fan3LowO.ToString();
            txtFan3HighT.Text = Fan3HighT.ToString();
            txtFan3HighO.Text = Fan3HighO.ToString();
            txtFan3Hys.Text = Fan3Hys.ToString();

            txtFan1LowT.BackColor = cShadeLight;
            txtFan1LowO.BackColor = cShadeLight;
            txtFan1HighT.BackColor = cShadeLight;
            txtFan1HighO.BackColor = cShadeLight;
            txtFan1Hys.BackColor = cShadeLight;
            txtFan2LowT.BackColor = cShadeLight;
            txtFan2LowO.BackColor = cShadeLight;
            txtFan2HighT.BackColor = cShadeLight;
            txtFan2HighO.BackColor = cShadeLight;
            txtFan2Hys.BackColor = cShadeLight;
            txtFan3LowT.BackColor = cShadeLight;
            txtFan3LowO.BackColor = cShadeLight;
            txtFan3HighT.BackColor = cShadeLight;
            txtFan3HighO.BackColor = cShadeLight;
            txtFan3Hys.BackColor = cShadeLight;
        }

        /*
         * Procedure to update all UI values on the Alarm page
         */
        public void UpdateUiAlarms()
        {
            txtVRM_A.Text = VRM_Temp_alarm.ToString();
            txtCPU_A.Text = CPU_Temp_alarm.ToString();
            txtGPU_A.Text = GPU_Temp_alarm.ToString();
            txtSYS_A.Text = SYS_Temp_alarm.ToString();
            txtCASEB_A.Text = (CASEB_Temp_alarm/10).ToString();
            txtCaseT_A.Text = (CASET_Temp_alarm/10).ToString();
            txtRad_A.Text = (RAD_Temp_alarm/10).ToString();
            txtFlow_A.Text = FLOW_alarm.ToString();

            txtVRM_A.BackColor = cShadeLight;
            txtCPU_A.BackColor = cShadeLight;
            txtGPU_A.BackColor = cShadeLight;
            txtSYS_A.BackColor = cShadeLight;
            txtCASEB_A.BackColor = cShadeLight;
            txtCaseT_A.BackColor = cShadeLight;
            txtRad_A.BackColor = cShadeLight;
            txtFlow_A.BackColor = cShadeLight;
        }

        /*
         * Invoked by timer, append data received by COM port to the debug textbox
         */
        private void UpdateUIRecv(string labelText)
        {
            txtReceive.AppendText(DateTime.Now + " << " + labelText + Environment.NewLine);
        }

        /*
         * Background worker to update all the labels on the status page. As this is called by the 
         * timer it also checks if the status page or fan page is active and updates the plots 
         * accordingly.
         */
        private void backgroundWorkerUI_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblT_VRM.Text = String.Format(VRM_Temp.ToString() + " °C\r");
            CPU_Temp_avg = Math.Round((CPU_Temp[0] + CPU_Temp[1] + CPU_Temp[2]) / 3);
            lblT_CPU.Text = String.Format(CPU_Temp_avg.ToString() + " °C\r");
            lblP_CPU.Text = String.Format(CPU_Perc.ToString() + " %\r");
            lblT_GPU.Text = String.Format(GPU_Temp.ToString() + " °C\r");
            lblP_GPU.Text = String.Format(GPU_Perc.ToString() + " %\r");
            lblT_SYS.Text = String.Format(SYS_Temp.ToString() + " °C\r");

            lblT_CASEB.Text = String.Format(CASEB_Temp.ToString() + " °C\r");
            lblT_CASET.Text = String.Format(CASET_Temp.ToString() + " °C\r");
            lblF_CASET.Text = String.Format(CASET_Fan.ToString() + " %\r");
            lblT_RAD.Text = String.Format(RAD_Temp.ToString() + " °C\r");
            lblF_RAD.Text = String.Format(RAD_Fan.ToString() + " %\r");
            lblF_AON.Text = String.Format(AON_Fan.ToString() + " %\r");
            lblFLOW.Text = String.Format(FLOW.ToString() + " L/h\r");

            SerialSend = (String.Format("P:" + VRM_Temp.ToString("000") + ":" + CPU_Temp_avg.ToString("000") + ":" + CPU_Perc.ToString("000") + ":" + GPU_Temp.ToString("000") + ":" + GPU_Perc.ToString("000") + ":" + SYS_Temp.ToString("000") + ";\n"));
            if (ComPort.IsOpen)
            {
                ComPort.Write(SerialSend);
                txtSend.AppendText(DateTime.Now + " >> " + SerialSend + Environment.NewLine);
            }

            if (managedPanelFans.Visible == true) PlotFanGraph();
            if (managedPanelStatus.Visible == true) PlotStatusGraph();
        }

        /*
         * When cloasing Form1, write "--" to the tempfile to indicate values are no longer being updated. 
         */
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.StreamWriter objWriter = new System.IO.StreamWriter(temp_file);
            objWriter.Write("--");
            objWriter.Close();
        }

        /*
         * This button advances the interface by sending I:; to the control unit
         */
        private void btnIface_Click(object sender, EventArgs e)
        {
            SerialSend = ("I:;\n");
            if (ComPort.IsOpen)
            {
                Console.WriteLine(SerialSend);
                ComPort.Write(SerialSend);
                txtSend.AppendText(DateTime.Now + " >> " + SerialSend + Environment.NewLine);
            }
        }

        /*
         * The Log button asks for a file to associate with the streamwriter. No further action is needed
         * as the application logs in default to a null streamwriter at all times. Simply assigning a file
         * starts the logging process. To end logging we can simply dispose of the streamwriter.
         */
        private void btnLog_Click(object sender, EventArgs e)
        {
            if (sw == null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sw = new StreamWriter(File.OpenWrite(saveFileDialog1.FileName));
                    btnLog.Text = "Stop Logging";
                    sw.WriteLine(
                        "Date Time," +
                        "Radiator Temp," +
                        "Flow Rate L/h," +
                        "Case Bottom Temp," +
                        "Case Top Temp," +
                        "Radiator Fans," +
                        "Case Top Fans," +
                        "Always-On Fan," +
                        "VRM Temp," +
                        "CPU Temp," +
                        "CPU Utilisation," +
                        "GPU Temp," +
                        "GPU Utilisation," +
                        "System Temp");
                }
            }
            else
            {
                sw.Dispose();
                sw = null;
                btnLog.Text = "Log to File";
            }
        }

        /*
         * When the alarm button is pressed send the updated alarms and then reset the colours
         * on all of the textboxes.
         */
        private void btnAlarms_Click(object sender, EventArgs e)
        {
            VRM_Temp_alarm = Convert.ToDouble(txtVRM_A.Text);
            CPU_Temp_alarm = Convert.ToDouble(txtCPU_A.Text);
            GPU_Temp_alarm = Convert.ToDouble(txtGPU_A.Text);
            SYS_Temp_alarm = Convert.ToDouble(txtSYS_A.Text);
            CASEB_Temp_alarm = Convert.ToDouble(txtCASEB_A.Text)*10;
            CASET_Temp_alarm = Convert.ToDouble(txtCaseT_A.Text)*10;
            RAD_Temp_alarm = Convert.ToDouble(txtRad_A.Text)*10;
            FLOW_alarm = Convert.ToDouble(txtFlow_A.Text);
            SerialSend = (String.Format("B:" + VRM_Temp_alarm.ToString("000") + ":" + CPU_Temp_alarm.ToString("000") + ":" + GPU_Temp_alarm.ToString("000")
                + ":" + SYS_Temp_alarm.ToString("000") + ":" + CASEB_Temp_alarm.ToString("000") + ":" + CASET_Temp_alarm.ToString("000") + ":" + RAD_Temp_alarm.ToString("000")
                + ":" + FLOW_alarm.ToString("000") + ";\n"));
            if (ComPort.IsOpen)
            {
                Console.WriteLine(SerialSend);
                ComPort.Write(SerialSend);
                txtSend.AppendText(DateTime.Now + " >> " + SerialSend + Environment.NewLine);
                txtVRM_A.BackColor = cShadeLight;
                txtCPU_A.BackColor = cShadeLight;
                txtGPU_A.BackColor = cShadeLight;
                txtSYS_A.BackColor = cShadeLight;
                txtCASEB_A.BackColor = cShadeLight;
                txtCaseT_A.BackColor = cShadeLight;
                txtRad_A.BackColor = cShadeLight;
                txtFlow_A.BackColor = cShadeLight;
            }
            else
            {
                MessageBox.Show("The Controller is not currently connected. Unable to send Alarm Settings.", "Not Connected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /*
         * Select the Status Page
         */
        private void btnMenuStatus_Click(object sender, EventArgs e)
        {
            panelManager1.SelectedPanel = managedPanelStatus;
            btnMenuStatus.BackColor = cMainBack;
            btnMenuFans.BackColor = cSidebarBack;
            btnMenuAlarms.BackColor = cSidebarBack;
            btnMenuController.BackColor = cSidebarBack;
        }

        /*
         * Select the Fans Page
         */
        private void btnMenuFans_Click(object sender, EventArgs e)
        {
            panelManager1.SelectedPanel = managedPanelFans;
            btnMenuStatus.BackColor = cSidebarBack;
            btnMenuFans.BackColor = cMainBack;
            btnMenuAlarms.BackColor = cSidebarBack;
            btnMenuController.BackColor = cSidebarBack;
        }

        /*
         * Select the Alarms Page
         */
        private void btnMenuAlarms_Click(object sender, EventArgs e)
        {
            panelManager1.SelectedPanel = managedPanelAlarms;
            btnMenuStatus.BackColor = cSidebarBack;
            btnMenuFans.BackColor = cSidebarBack;
            btnMenuAlarms.BackColor = cMainBack;
            btnMenuController.BackColor = cSidebarBack;
        }

        /*
         * Select the Controller Page
         */
        private void btnMenuController_Click(object sender, EventArgs e)
        {
            panelManager1.SelectedPanel = managedPanelCtrl;
            btnMenuStatus.BackColor = cSidebarBack;
            btnMenuFans.BackColor = cSidebarBack;
            btnMenuAlarms.BackColor = cSidebarBack;
            btnMenuController.BackColor = cMainBack;
        }

        /*
         * Handler for the minimise button
         */
        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*
         * Handler for the close button
         */
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
         * This routine traps the mouse button click on the title area to allow the user
         * to drag the window.
         */
        private void Title_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /*
         * Event handler for the second connect buttom (title area)
         */
        private void btnConnect2_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                Disconnect();
            }
            else
            {
                Connect();
            }
        }

        /*
         * When clicking refresh update the port list
         */
        private void btnCOMRefresh_Click(object sender, EventArgs e)
        {
            updatePorts();
        }

        /*
         * Trigger a controller reset by sending R:;
         */
        private void btnReset_Click(object sender, EventArgs e)
        {
            SerialSend = ("R:;\n");
            if (ComPort.IsOpen)
            {
                Console.WriteLine(SerialSend);
                ComPort.Write(SerialSend);
                txtSend.AppendText(DateTime.Now + " >> " + SerialSend + Environment.NewLine);
            }
        }

        /*
         * If the textbox values get changed this routine changes their background
         * colour to indicate that there is an update pending to be written to the 
         * controller.
         */
        private void txtAlarms_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = cButtonBack;
        }

        /*
         * This routine sends the new fan values to the controller and resets the colours
         * of the fan textboxes.
         */
        private void btnFan_Click(object sender, EventArgs e)
        {
            Fan1LowT = Convert.ToDouble(txtFan1LowT.Text);
            Fan1LowO = Convert.ToDouble(txtFan1LowO.Text);
            Fan1HighT = Convert.ToDouble(txtFan1HighT.Text);
            Fan1HighO = Convert.ToDouble(txtFan1HighO.Text);
            Fan1Hys = Convert.ToDouble(txtFan1Hys.Text);
            Fan2LowT = Convert.ToDouble(txtFan2LowT.Text);
            Fan2LowO = Convert.ToDouble(txtFan2LowO.Text);
            Fan2HighT = Convert.ToDouble(txtFan2HighT.Text);
            Fan2HighO = Convert.ToDouble(txtFan2HighO.Text);
            Fan2Hys = Convert.ToDouble(txtFan2Hys.Text);
            Fan3LowT = Convert.ToDouble(txtFan3LowT.Text);
            Fan3LowO = Convert.ToDouble(txtFan3LowO.Text);
            Fan3HighT = Convert.ToDouble(txtFan3HighT.Text);
            Fan3HighO = Convert.ToDouble(txtFan3HighO.Text);
            Fan3Hys = Convert.ToDouble(txtFan3Hys.Text);
            SerialSend = (String.Format("G:"
                + Fan1LowT.ToString("000") + ":" + Fan1LowO.ToString("000") + ":" + Fan1HighT.ToString("000") + ":" + Fan1HighO.ToString("000") + ":" + Fan1Hys.ToString("000") + ":"
                + Fan2LowT.ToString("000") + ":" + Fan2LowO.ToString("000") + ":" + Fan2HighT.ToString("000") + ":" + Fan2HighO.ToString("000") + ":" + Fan2Hys.ToString("000") + ":"
                + Fan3LowT.ToString("000") + ":" + Fan3LowO.ToString("000") + ":" + Fan3HighT.ToString("000") + ":" + Fan3HighO.ToString("000") + ":" + Fan3Hys.ToString("000") + ":"
                + Iface.ToString("000") + ";\n"));
            if (ComPort.IsOpen)
            {
                Console.WriteLine(SerialSend);
                ComPort.Write(SerialSend);
                txtSend.AppendText(DateTime.Now + " >> " + SerialSend + Environment.NewLine);
                txtFan1LowT.BackColor = cShadeLight;
                txtFan1LowO.BackColor = cShadeLight;
                txtFan1HighT.BackColor = cShadeLight;
                txtFan1HighO.BackColor = cShadeLight;
                txtFan1Hys.BackColor = cShadeLight;
                txtFan2LowT.BackColor = cShadeLight;
                txtFan2LowO.BackColor = cShadeLight;
                txtFan2HighT.BackColor = cShadeLight;
                txtFan2HighO.BackColor = cShadeLight;
                txtFan2Hys.BackColor = cShadeLight;
                txtFan3LowT.BackColor = cShadeLight;
                txtFan3LowO.BackColor = cShadeLight;
                txtFan3HighT.BackColor = cShadeLight;
                txtFan3HighO.BackColor = cShadeLight;
                txtFan3Hys.BackColor = cShadeLight;
            }
        }

        /*
         * If the textbox values get changed this routine changes their background
         * colour to indicate that there is an update pending to be written to the 
         * controller.
         */
        private void TextFan_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = cButtonBack;
        }

        /*
         * This routine calcaulates and draws the lines for the Fan Graph
         */
        private void PlotFanGraph()
        {
            myMasterpane = zedGFan.MasterPane;
            myMasterpane.Border.IsVisible = false;

            myPane = zedGFan.GraphPane;
            myPane.CurveList.Clear();

            myPane.Fill = new Fill(cMainBack);
            myPane.Border.IsVisible = false;
            myPane.Chart.Fill = new Fill(cMainBack);
            myPane.Chart.Border.IsVisible = false;
            
            
            myPane.Legend.IsVisible = false;

            myPane.Title.IsVisible = false;
            
            myPane.XAxis.Title.Text = "Temperature (°C)";
            myPane.XAxis.Title.FontSpec.Size = 16.0f;
            myPane.XAxis.Title.FontSpec.FontColor = cTextDark;
            myPane.XAxis.Scale.Min = 20;
            myPane.XAxis.Scale.Max = 60;
            myPane.XAxis.Scale.MajorStepAuto = false;
            myPane.XAxis.Scale.MajorStep = 10;
            myPane.XAxis.Scale.MinorStep = 5;
            myPane.XAxis.MajorGrid.Color = cButtonBorder;
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.MajorGrid.DashOff = 0;
            myPane.XAxis.MinorGrid.Color = cButtonBorder;
            myPane.XAxis.MinorGrid.IsVisible = true;
            myPane.XAxis.MinorGrid.DashOff = 0;
            myPane.XAxis.Color = cTextDark;

            myPane.YAxis.Title.Text = "Fan Output (%)";
            myPane.YAxis.Title.FontSpec.Size = 16.0f;
            myPane.YAxis.Title.FontSpec.FontColor = cTextDark;
            myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 102;
            myPane.YAxis.Scale.MajorStepAuto = false;
            myPane.YAxis.Scale.MajorStep = 10;
            myPane.YAxis.Scale.MinorStep = 10;
            myPane.YAxis.MajorGrid.Color = cButtonBorder;
            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.DashOff = 0;
            myPane.YAxis.Color = cTextDark;

            Fan1PointPair.Clear();
            Fan2PointPair.Clear();
            Fan3PointPair.Clear();
            FanTPointPair.Clear();

            Fan1PointPair.Add(0, Fan1LowO);
            Fan1PointPair.Add(Fan1LowT, Fan1LowO);
            Fan1PointPair.Add(Fan1HighT, Fan1HighO);
            Fan1PointPair.Add(Fan1HighT, 100);
            Fan2PointPair.Add(0, Fan2LowO);
            Fan2PointPair.Add(Fan2LowT, Fan2LowO);
            Fan2PointPair.Add(Fan2HighT, Fan2HighO);
            Fan2PointPair.Add(Fan2HighT, 100);
            Fan3PointPair.Add(0, Fan3LowO);
            Fan3PointPair.Add(Fan3LowT, Fan3LowO);
            Fan3PointPair.Add(Fan3HighT, Fan3HighO);
            Fan3PointPair.Add(Fan3HighT, 100);
            FanTPointPair.Add(RAD_Temp, 0);
            FanTPointPair.Add(RAD_Temp, 100);

            Fan1Curve = new LineItem("Fan1", Fan1PointPair, cAccentG, SymbolType.None, 2.0F);
            Fan2Curve = new LineItem("Fan2", Fan2PointPair, cAccentB, SymbolType.None, 2.0F);
            Fan3Curve = new LineItem("Fan3", Fan3PointPair, cAccentP, SymbolType.None, 2.0F);
            FanTCurve = new LineItem("FanT", FanTPointPair, cTextDark, SymbolType.None, 3.0F);
            Fan1Curve.Line.IsAntiAlias = true;
            Fan2Curve.Line.IsAntiAlias = true;
            Fan3Curve.Line.IsAntiAlias = true;
            FanTCurve.Line.IsAntiAlias = true;

            myPane.CurveList.Add(Fan1Curve);
            myPane.CurveList.Add(Fan2Curve);
            myPane.CurveList.Add(Fan3Curve);
            myPane.CurveList.Add(FanTCurve);
            
            zedGFan.Invalidate();

        }

        /*
         * Due to the fan graph being updated on a timer, this ensures the graph
         * is actually drawn when the fan page is first selected, otherwise
         * it just pops in after a delay.
         */
        private void managedPanelFans_VisibleChanged(object sender, EventArgs e)
        {
            PlotFanGraph();
        }

        /*
         * This routine calcaulates and draws the lines for the Status Graph
         */
        private void PlotStatusGraph()
        {
            myMasterpane2 = zedGTemps.MasterPane;
            myMasterpane2.Border.IsVisible = false;

            myPane2 = zedGTemps.GraphPane;
            myPane2.CurveList.Clear();

            myPane2.Fill = new Fill(cMainBack);
            myPane2.Border.IsVisible = false;
            myPane2.Chart.Fill = new Fill(cMainBack);
            myPane2.Chart.Border.IsVisible = false;


            myPane2.Legend.IsVisible = false;

            myPane2.Title.IsVisible = false;

            myPane2.XAxis.Title.Text = "Time (Sec)";
            myPane2.XAxis.Title.FontSpec.Size = 24.0f;
            myPane2.XAxis.Title.FontSpec.FontColor = cTextDark;
            myPane2.XAxis.Scale.FontSpec.Size = 22.0f;
            myPane2.XAxis.Scale.Min = history_length * -1;
            myPane2.XAxis.Scale.Max = 0;
            myPane2.XAxis.Scale.MajorStepAuto = false;
            myPane2.XAxis.Scale.MajorStep = 120;
            myPane2.XAxis.Scale.MinorStep = 30;
            myPane2.XAxis.MajorGrid.Color = cButtonBorder;
            myPane2.XAxis.MajorGrid.IsVisible = true;
            myPane2.XAxis.MajorGrid.DashOff = 0;
            myPane2.XAxis.MinorGrid.Color = cButtonBorder;
            myPane2.XAxis.MinorGrid.IsVisible = true;
            myPane2.XAxis.MinorGrid.DashOff = 0;
            myPane2.XAxis.Color = cTextDark;

            myPane2.YAxis.Title.Text = "Temperature (°C)";
            myPane2.YAxis.Title.FontSpec.Size = 24.0f;
            myPane2.YAxis.Scale.FontSpec.Size = 22.0f;
            myPane2.YAxis.Title.FontSpec.FontColor = cTextDark;
            myPane2.YAxis.Scale.Min = 30;
            myPane2.YAxis.Scale.Max = 80;
            myPane2.YAxis.Scale.MajorStepAuto = false;
            myPane2.YAxis.Scale.MajorStep = 10;
            myPane2.YAxis.Scale.MinorStep = 10;
            myPane2.YAxis.MajorGrid.Color = cButtonBorder;
            myPane2.YAxis.MajorGrid.IsVisible = true;
            myPane2.YAxis.MajorGrid.DashOff = 0;
            myPane2.YAxis.Color = cTextDark;

            myPane2.Y2Axis.Title.Text = "Water (°C)";
            myPane2.Y2Axis.Title.FontSpec.Size = 24.0f;
            myPane2.Y2Axis.Scale.FontSpec.Size = 22.0f;
            myPane2.Y2Axis.Title.FontSpec.FontColor = cAccentB;
            myPane2.Y2Axis.Scale.Min = 20;
            myPane2.Y2Axis.Scale.Max = 45;
            myPane2.Y2Axis.Scale.MajorStepAuto = false;
            myPane2.Y2Axis.Scale.MajorStep = 5;
            myPane2.Y2Axis.Scale.MinorStep = 1;
            myPane2.Y2Axis.Color = cTextDark;
            myPane2.Y2Axis.IsVisible = true;


            TempWaterPointPair.Clear();
            TempCPUPointPair.Clear();
            TempGPUPointPair.Clear();
            
            for (int i = 0; i<history_length; i++)
            {
                TempWaterPointPair.Add((i * -1), HistoryWater[i]);
                TempCPUPointPair.Add((i * -1), HistoryCPU[i]);
                TempGPUPointPair.Add((i * -1), HistoryGPU[i]);
            }

            TempWaterCurve = new LineItem("Water Temperature", TempWaterPointPair, cAccentB, SymbolType.None, 2.0F);
            TempCPUCurve = new LineItem("CPU Temperature", TempCPUPointPair, cAccentP, SymbolType.None, 2.0F);
            TempGPUCurve = new LineItem("GPU Temperature", TempGPUPointPair, cAccentG, SymbolType.None, 2.0F);
            TempWaterCurve.Line.IsAntiAlias = true;
            TempWaterCurve.IsY2Axis = true;
            TempCPUCurve.Line.IsAntiAlias = true;
            TempGPUCurve.Line.IsAntiAlias = true;
            

            myPane2.CurveList.Add(TempWaterCurve);
            myPane2.CurveList.Add(TempCPUCurve);
            myPane2.CurveList.Add(TempGPUCurve);

            zedGTemps.Invalidate();
        }

        /*
         * Due to the status graph being updated on a timer, this ensures the graph
         * is actually drawn when the status page is first selected, otherwise
         * it just pops in after a delay.
         */
        private void managedPanelStatus_VisibleChanged(object sender, EventArgs e)
        {
            PlotStatusGraph();
        }

        /*
         * This procedure updates the fan variables and also updates redraws the fan 
         * graph when the textbox for fan is left. It was originally on an update, but
         * that caused all the textboxes to change colour when new values were written
         * to them via software.
         */ 
        private void TextFan_Leave(object sender, EventArgs e)
        {
            Fan1LowT = Convert.ToDouble(txtFan1LowT.Text);
            Fan1LowO = Convert.ToDouble(txtFan1LowO.Text);
            Fan1HighT = Convert.ToDouble(txtFan1HighT.Text);
            Fan1HighO = Convert.ToDouble(txtFan1HighO.Text);
            Fan1Hys = Convert.ToDouble(txtFan1Hys.Text);
            Fan2LowT = Convert.ToDouble(txtFan2LowT.Text);
            Fan2LowO = Convert.ToDouble(txtFan2LowO.Text);
            Fan2HighT = Convert.ToDouble(txtFan2HighT.Text);
            Fan2HighO = Convert.ToDouble(txtFan2HighO.Text);
            Fan2Hys = Convert.ToDouble(txtFan2Hys.Text);
            Fan3LowT = Convert.ToDouble(txtFan3LowT.Text);
            Fan3LowO = Convert.ToDouble(txtFan3LowO.Text);
            Fan3HighT = Convert.ToDouble(txtFan3HighT.Text);
            Fan3HighO = Convert.ToDouble(txtFan3HighO.Text);
            Fan3Hys = Convert.ToDouble(txtFan3Hys.Text);
            PlotFanGraph();
        }
    }
}
