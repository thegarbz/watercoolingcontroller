namespace FanControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelAlarmsTitle = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblT_CASEB = new System.Windows.Forms.Label();
            this.lblT_CASET = new System.Windows.Forms.Label();
            this.lblF_CASET = new System.Windows.Forms.Label();
            this.lblT_RAD = new System.Windows.Forms.Label();
            this.lblFLOW = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblF_AON = new System.Windows.Forms.Label();
            this.lblF_RAD = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorkerUI = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanelBack = new System.Windows.Forms.TableLayoutPanel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.tableLayoutPanelTitleBar = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConnect2 = new System.Windows.Forms.Button();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnMenuController = new System.Windows.Forms.Button();
            this.btnMenuAlarms = new System.Windows.Forms.Button();
            this.btnMenuFans = new System.Windows.Forms.Button();
            this.btnMenuStatus = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogoImage = new System.Windows.Forms.Label();
            this.lblLogoText = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelManager1 = new Controls.PanelManager();
            this.managedPanelStatus = new Controls.ManagedPanel();
            this.tableLayoutPanelStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lblStatusImage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblT_SYS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblP_GPU = new System.Windows.Forms.Label();
            this.lblT_GPU = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblP_CPU = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblT_CPU = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblT_VRM = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.zedGTemps = new ZedGraph.ZedGraphControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIface = new System.Windows.Forms.Button();
            this.managedPanelAlarms = new Controls.ManagedPanel();
            this.tableLayoutPanelAlarms = new System.Windows.Forms.TableLayoutPanel();
            this.txtRad_A = new System.Windows.Forms.TextBox();
            this.txtCaseT_A = new System.Windows.Forms.TextBox();
            this.txtCASEB_A = new System.Windows.Forms.TextBox();
            this.txtSYS_A = new System.Windows.Forms.TextBox();
            this.txtGPU_A = new System.Windows.Forms.TextBox();
            this.txtCPU_A = new System.Windows.Forms.TextBox();
            this.txtVRM_A = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAlarms = new System.Windows.Forms.Button();
            this.txtFlow_A = new System.Windows.Forms.TextBox();
            this.managedPanelFans = new Controls.ManagedPanel();
            this.tableLayoutPanelFans = new System.Windows.Forms.TableLayoutPanel();
            this.label45 = new System.Windows.Forms.Label();
            this.txtFan3Hys = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.txtFan2HighT = new System.Windows.Forms.TextBox();
            this.txtFan1Hys = new System.Windows.Forms.TextBox();
            this.txtFan2Hys = new System.Windows.Forms.TextBox();
            this.txtFan1LowT = new System.Windows.Forms.TextBox();
            this.txtFan1LowO = new System.Windows.Forms.TextBox();
            this.txtFan1HighT = new System.Windows.Forms.TextBox();
            this.txtFan3LowO = new System.Windows.Forms.TextBox();
            this.txtFan3HighT = new System.Windows.Forms.TextBox();
            this.txtFan3HighO = new System.Windows.Forms.TextBox();
            this.txtFan3LowT = new System.Windows.Forms.TextBox();
            this.txtFan2HighO = new System.Windows.Forms.TextBox();
            this.txtFan2LowO = new System.Windows.Forms.TextBox();
            this.txtFan2LowT = new System.Windows.Forms.TextBox();
            this.txtFan1HighO = new System.Windows.Forms.TextBox();
            this.btnFan = new System.Windows.Forms.Button();
            this.zedGFan = new ZedGraph.ZedGraphControl();
            this.managedPanelCtrl = new Controls.ManagedPanel();
            this.tableLayoutPanelDebug = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.paneltxtRecvBorder = new System.Windows.Forms.Panel();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.paneltxtSendBorder = new System.Windows.Forms.Panel();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelControl = new System.Windows.Forms.TableLayoutPanel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCOMRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanelBack.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.tableLayoutPanelTitleBar.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.tableLayoutPanelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelManager1.SuspendLayout();
            this.managedPanelStatus.SuspendLayout();
            this.tableLayoutPanelStatus.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.managedPanelAlarms.SuspendLayout();
            this.tableLayoutPanelAlarms.SuspendLayout();
            this.managedPanelFans.SuspendLayout();
            this.tableLayoutPanelFans.SuspendLayout();
            this.managedPanelCtrl.SuspendLayout();
            this.tableLayoutPanelDebug.SuspendLayout();
            this.paneltxtRecvBorder.SuspendLayout();
            this.paneltxtSendBorder.SuspendLayout();
            this.tableLayoutPanelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAlarmsTitle
            // 
            this.labelAlarmsTitle.AutoSize = true;
            this.tableLayoutPanelAlarms.SetColumnSpan(this.labelAlarmsTitle, 3);
            this.labelAlarmsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAlarmsTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.labelAlarmsTitle.Location = new System.Drawing.Point(3, 3);
            this.labelAlarmsTitle.Margin = new System.Windows.Forms.Padding(3);
            this.labelAlarmsTitle.Name = "labelAlarmsTitle";
            this.labelAlarmsTitle.Size = new System.Drawing.Size(443, 39);
            this.labelAlarmsTitle.TabIndex = 15;
            this.labelAlarmsTitle.Text = "Alarm Settings";
            this.labelAlarmsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnConnect.FlatAppearance.BorderSize = 2;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btnConnect.Location = new System.Drawing.Point(257, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(87, 28);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbPortName
            // 
            this.cmbPortName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cmbPortName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPortName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPortName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(3, 3);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(92, 23);
            this.cmbPortName.TabIndex = 2;
            this.cmbPortName.Text = "COM Port";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label7.Location = new System.Drawing.Point(458, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Case Bottom Temp";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label12.Location = new System.Drawing.Point(458, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 28);
            this.label12.TabIndex = 25;
            this.label12.Text = "Case Top Temp";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblT_CASEB
            // 
            this.lblT_CASEB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblT_CASEB.AutoSize = true;
            this.lblT_CASEB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_CASEB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.lblT_CASEB.Location = new System.Drawing.Point(590, 206);
            this.lblT_CASEB.Margin = new System.Windows.Forms.Padding(0);
            this.lblT_CASEB.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblT_CASEB.Name = "lblT_CASEB";
            this.lblT_CASEB.Size = new System.Drawing.Size(54, 23);
            this.lblT_CASEB.TabIndex = 26;
            this.lblT_CASEB.Text = "000%";
            this.lblT_CASEB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblT_CASET
            // 
            this.lblT_CASET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblT_CASET.AutoSize = true;
            this.lblT_CASET.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_CASET.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.lblT_CASET.Location = new System.Drawing.Point(590, 12);
            this.lblT_CASET.Margin = new System.Windows.Forms.Padding(0);
            this.lblT_CASET.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblT_CASET.Name = "lblT_CASET";
            this.lblT_CASET.Size = new System.Drawing.Size(54, 23);
            this.lblT_CASET.TabIndex = 27;
            this.lblT_CASET.Text = "000%";
            this.lblT_CASET.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblF_CASET
            // 
            this.lblF_CASET.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblF_CASET.AutoSize = true;
            this.lblF_CASET.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF_CASET.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.lblF_CASET.Location = new System.Drawing.Point(590, 36);
            this.lblF_CASET.Margin = new System.Windows.Forms.Padding(0);
            this.lblF_CASET.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblF_CASET.Name = "lblF_CASET";
            this.lblF_CASET.Size = new System.Drawing.Size(54, 23);
            this.lblF_CASET.TabIndex = 28;
            this.lblF_CASET.Text = "000%";
            this.lblF_CASET.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblT_RAD
            // 
            this.lblT_RAD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblT_RAD.AutoSize = true;
            this.lblT_RAD.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_RAD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.lblT_RAD.Location = new System.Drawing.Point(590, 141);
            this.lblT_RAD.Margin = new System.Windows.Forms.Padding(0);
            this.lblT_RAD.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblT_RAD.Name = "lblT_RAD";
            this.lblT_RAD.Size = new System.Drawing.Size(54, 23);
            this.lblT_RAD.TabIndex = 29;
            this.lblT_RAD.Text = "000%";
            this.lblT_RAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFLOW
            // 
            this.lblFLOW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFLOW.AutoSize = true;
            this.lblFLOW.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFLOW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.lblFLOW.Location = new System.Drawing.Point(590, 166);
            this.lblFLOW.Margin = new System.Windows.Forms.Padding(0);
            this.lblFLOW.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblFLOW.Name = "lblFLOW";
            this.lblFLOW.Size = new System.Drawing.Size(54, 23);
            this.lblFLOW.TabIndex = 31;
            this.lblFLOW.Text = "000%";
            this.lblFLOW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label10.Location = new System.Drawing.Point(458, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Case Top Fan";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label23.Location = new System.Drawing.Point(458, 140);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(125, 25);
            this.label23.TabIndex = 36;
            this.label23.Text = "Water Temp";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label24.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label24.Location = new System.Drawing.Point(458, 100);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(125, 25);
            this.label24.TabIndex = 37;
            this.label24.Text = "Radiator Fan (Sec)";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label25.Location = new System.Drawing.Point(458, 165);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(125, 25);
            this.label25.TabIndex = 38;
            this.label25.Text = "Water Flow";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblF_AON
            // 
            this.lblF_AON.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblF_AON.AutoSize = true;
            this.lblF_AON.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF_AON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.lblF_AON.Location = new System.Drawing.Point(590, 76);
            this.lblF_AON.Margin = new System.Windows.Forms.Padding(0);
            this.lblF_AON.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblF_AON.Name = "lblF_AON";
            this.lblF_AON.Size = new System.Drawing.Size(54, 23);
            this.lblF_AON.TabIndex = 40;
            this.lblF_AON.Text = "000%";
            this.lblF_AON.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblF_RAD
            // 
            this.lblF_RAD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblF_RAD.AutoSize = true;
            this.lblF_RAD.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF_RAD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.lblF_RAD.Location = new System.Drawing.Point(590, 101);
            this.lblF_RAD.Margin = new System.Windows.Forms.Padding(0);
            this.lblF_RAD.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblF_RAD.Name = "lblF_RAD";
            this.lblF_RAD.Size = new System.Drawing.Size(54, 23);
            this.lblF_RAD.TabIndex = 30;
            this.lblF_RAD.Text = "000%";
            this.lblF_RAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnLog.FlatAppearance.BorderSize = 2;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btnLog.Location = new System.Drawing.Point(3, 3);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(87, 28);
            this.btnLog.TabIndex = 55;
            this.btnLog.Text = "Log to File";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 1000;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Fan Controller Windows interface";
            this.notifyIcon.BalloonTipTitle = "Fan Controller";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Fan Controller Windows Interface";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // backgroundWorkerUI
            // 
            this.backgroundWorkerUI.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerUI_RunWorkerCompleted);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "log";
            this.saveFileDialog1.FileName = "WaterLoopLog";
            this.saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // tableLayoutPanelBack
            // 
            this.tableLayoutPanelBack.ColumnCount = 2;
            this.tableLayoutPanelBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanelBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBack.Controls.Add(this.panelTitle, 1, 0);
            this.tableLayoutPanelBack.Controls.Add(this.panelLeft, 0, 1);
            this.tableLayoutPanelBack.Controls.Add(this.panelLogo, 0, 0);
            this.tableLayoutPanelBack.Controls.Add(this.panelContent, 1, 1);
            this.tableLayoutPanelBack.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBack.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelBack.Name = "tableLayoutPanelBack";
            this.tableLayoutPanelBack.RowCount = 2;
            this.tableLayoutPanelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBack.Size = new System.Drawing.Size(850, 500);
            this.tableLayoutPanelBack.TabIndex = 3;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.Controls.Add(this.tableLayoutPanelTitleBar);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(180, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(670, 45);
            this.panelTitle.TabIndex = 2;
            // 
            // tableLayoutPanelTitleBar
            // 
            this.tableLayoutPanelTitleBar.ColumnCount = 5;
            this.tableLayoutPanelTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelTitleBar.Controls.Add(this.btnClose, 4, 0);
            this.tableLayoutPanelTitleBar.Controls.Add(this.btnConnect2, 1, 0);
            this.tableLayoutPanelTitleBar.Controls.Add(this.btnMinimise, 3, 0);
            this.tableLayoutPanelTitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTitleBar.Name = "tableLayoutPanelTitleBar";
            this.tableLayoutPanelTitleBar.RowCount = 1;
            this.tableLayoutPanelTitleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTitleBar.Size = new System.Drawing.Size(670, 45);
            this.tableLayoutPanelTitleBar.TabIndex = 0;
            this.tableLayoutPanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(628, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConnect2
            // 
            this.btnConnect2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnConnect2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnConnect2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnConnect2.FlatAppearance.BorderSize = 2;
            this.btnConnect2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect2.ForeColor = System.Drawing.Color.White;
            this.btnConnect2.Location = new System.Drawing.Point(48, 8);
            this.btnConnect2.Name = "btnConnect2";
            this.btnConnect2.Size = new System.Drawing.Size(110, 28);
            this.btnConnect2.TabIndex = 0;
            this.btnConnect2.Text = "DISCONNECTED";
            this.btnConnect2.UseVisualStyleBackColor = false;
            this.btnConnect2.Click += new System.EventHandler(this.btnConnect2_Click);
            // 
            // btnMinimise
            // 
            this.btnMinimise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimise.Image")));
            this.btnMinimise.Location = new System.Drawing.Point(583, 3);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(39, 39);
            this.btnMinimise.TabIndex = 1;
            this.btnMinimise.TabStop = false;
            this.btnMinimise.UseVisualStyleBackColor = true;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLeft.Controls.Add(this.tableLayoutPanelMenu);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 45);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(180, 455);
            this.panelLeft.TabIndex = 0;
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.tableLayoutPanelMenu.ColumnCount = 1;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.Controls.Add(this.btnMenuController, 0, 4);
            this.tableLayoutPanelMenu.Controls.Add(this.btnMenuAlarms, 0, 3);
            this.tableLayoutPanelMenu.Controls.Add(this.btnMenuFans, 0, 2);
            this.tableLayoutPanelMenu.Controls.Add(this.btnMenuStatus, 0, 1);
            this.tableLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.RowCount = 6;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(180, 455);
            this.tableLayoutPanelMenu.TabIndex = 0;
            // 
            // btnMenuController
            // 
            this.btnMenuController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.btnMenuController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuController.FlatAppearance.BorderSize = 0;
            this.btnMenuController.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuController.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuController.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(170)))), ((int)(((byte)(189)))));
            this.btnMenuController.Location = new System.Drawing.Point(0, 170);
            this.btnMenuController.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuController.Name = "btnMenuController";
            this.btnMenuController.Size = new System.Drawing.Size(180, 50);
            this.btnMenuController.TabIndex = 5;
            this.btnMenuController.Text = "CONTROLLER";
            this.btnMenuController.UseVisualStyleBackColor = false;
            this.btnMenuController.Click += new System.EventHandler(this.btnMenuController_Click);
            // 
            // btnMenuAlarms
            // 
            this.btnMenuAlarms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuAlarms.FlatAppearance.BorderSize = 0;
            this.btnMenuAlarms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAlarms.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAlarms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(170)))), ((int)(((byte)(189)))));
            this.btnMenuAlarms.Location = new System.Drawing.Point(0, 120);
            this.btnMenuAlarms.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuAlarms.Name = "btnMenuAlarms";
            this.btnMenuAlarms.Size = new System.Drawing.Size(180, 50);
            this.btnMenuAlarms.TabIndex = 4;
            this.btnMenuAlarms.Text = "ALARMS";
            this.btnMenuAlarms.UseVisualStyleBackColor = true;
            this.btnMenuAlarms.Click += new System.EventHandler(this.btnMenuAlarms_Click);
            // 
            // btnMenuFans
            // 
            this.btnMenuFans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuFans.FlatAppearance.BorderSize = 0;
            this.btnMenuFans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuFans.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuFans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(170)))), ((int)(((byte)(189)))));
            this.btnMenuFans.Location = new System.Drawing.Point(0, 70);
            this.btnMenuFans.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuFans.Name = "btnMenuFans";
            this.btnMenuFans.Size = new System.Drawing.Size(180, 50);
            this.btnMenuFans.TabIndex = 3;
            this.btnMenuFans.Text = "FAN CURVES";
            this.btnMenuFans.UseVisualStyleBackColor = true;
            this.btnMenuFans.Click += new System.EventHandler(this.btnMenuFans_Click);
            // 
            // btnMenuStatus
            // 
            this.btnMenuStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnMenuStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuStatus.FlatAppearance.BorderSize = 0;
            this.btnMenuStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuStatus.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(170)))), ((int)(((byte)(189)))));
            this.btnMenuStatus.Location = new System.Drawing.Point(0, 20);
            this.btnMenuStatus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuStatus.Name = "btnMenuStatus";
            this.btnMenuStatus.Size = new System.Drawing.Size(180, 50);
            this.btnMenuStatus.TabIndex = 0;
            this.btnMenuStatus.Text = "STATUS";
            this.btnMenuStatus.UseVisualStyleBackColor = false;
            this.btnMenuStatus.Click += new System.EventHandler(this.btnMenuStatus_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.panelLogo.Controls.Add(this.lblLogoImage);
            this.panelLogo.Controls.Add(this.lblLogoText);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 45);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            // 
            // lblLogoImage
            // 
            this.lblLogoImage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLogoImage.Image = ((System.Drawing.Image)(resources.GetObject("lblLogoImage.Image")));
            this.lblLogoImage.Location = new System.Drawing.Point(0, 0);
            this.lblLogoImage.Margin = new System.Windows.Forms.Padding(0);
            this.lblLogoImage.Name = "lblLogoImage";
            this.lblLogoImage.Size = new System.Drawing.Size(45, 45);
            this.lblLogoImage.TabIndex = 2;
            // 
            // lblLogoText
            // 
            this.lblLogoText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLogoText.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.lblLogoText.Location = new System.Drawing.Point(45, 0);
            this.lblLogoText.Margin = new System.Windows.Forms.Padding(0);
            this.lblLogoText.Name = "lblLogoText";
            this.lblLogoText.Size = new System.Drawing.Size(132, 45);
            this.lblLogoText.TabIndex = 1;
            this.lblLogoText.Text = "FAN CONTROL";
            this.lblLogoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelContent.Controls.Add(this.panelManager1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(180, 45);
            this.panelContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(670, 455);
            this.panelContent.TabIndex = 3;
            // 
            // panelManager1
            // 
            this.panelManager1.Controls.Add(this.managedPanelStatus);
            this.panelManager1.Controls.Add(this.managedPanelAlarms);
            this.panelManager1.Controls.Add(this.managedPanelFans);
            this.panelManager1.Controls.Add(this.managedPanelCtrl);
            this.panelManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManager1.Location = new System.Drawing.Point(0, 0);
            this.panelManager1.Name = "panelManager1";
            this.panelManager1.SelectedIndex = 0;
            this.panelManager1.SelectedPanel = this.managedPanelStatus;
            this.panelManager1.Size = new System.Drawing.Size(670, 455);
            this.panelManager1.TabIndex = 0;
            // 
            // managedPanelStatus
            // 
            this.managedPanelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.managedPanelStatus.Controls.Add(this.tableLayoutPanelStatus);
            this.managedPanelStatus.Location = new System.Drawing.Point(0, 0);
            this.managedPanelStatus.Name = "managedPanelStatus";
            this.managedPanelStatus.Size = new System.Drawing.Size(670, 455);
            this.managedPanelStatus.Text = "000%";
            this.managedPanelStatus.VisibleChanged += new System.EventHandler(this.managedPanelStatus_VisibleChanged);
            // 
            // tableLayoutPanelStatus
            // 
            this.tableLayoutPanelStatus.ColumnCount = 5;
            this.tableLayoutPanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelStatus.Controls.Add(this.lblStatusImage, 2, 0);
            this.tableLayoutPanelStatus.Controls.Add(this.lblT_CASEB, 4, 9);
            this.tableLayoutPanelStatus.Controls.Add(this.label7, 3, 9);
            this.tableLayoutPanelStatus.Controls.Add(this.lblFLOW, 4, 7);
            this.tableLayoutPanelStatus.Controls.Add(this.lblT_RAD, 4, 6);
            this.tableLayoutPanelStatus.Controls.Add(this.label25, 3, 7);
            this.tableLayoutPanelStatus.Controls.Add(this.label23, 3, 6);
            this.tableLayoutPanelStatus.Controls.Add(this.lblF_RAD, 4, 4);
            this.tableLayoutPanelStatus.Controls.Add(this.lblF_CASET, 4, 1);
            this.tableLayoutPanelStatus.Controls.Add(this.label24, 3, 4);
            this.tableLayoutPanelStatus.Controls.Add(this.lblT_CASET, 4, 0);
            this.tableLayoutPanelStatus.Controls.Add(this.label10, 3, 1);
            this.tableLayoutPanelStatus.Controls.Add(this.label12, 3, 0);
            this.tableLayoutPanelStatus.Controls.Add(this.label6, 0, 9);
            this.tableLayoutPanelStatus.Controls.Add(this.lblT_SYS, 1, 9);
            this.tableLayoutPanelStatus.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanelStatus.Controls.Add(this.lblP_GPU, 1, 7);
            this.tableLayoutPanelStatus.Controls.Add(this.lblT_GPU, 1, 6);
            this.tableLayoutPanelStatus.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanelStatus.Controls.Add(this.lblP_CPU, 1, 4);
            this.tableLayoutPanelStatus.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanelStatus.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanelStatus.Controls.Add(this.lblT_CPU, 1, 3);
            this.tableLayoutPanelStatus.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanelStatus.Controls.Add(this.lblT_VRM, 1, 1);
            this.tableLayoutPanelStatus.Controls.Add(this.lblF_AON, 4, 3);
            this.tableLayoutPanelStatus.Controls.Add(this.label8, 3, 3);
            this.tableLayoutPanelStatus.Controls.Add(this.zedGTemps, 3, 10);
            this.tableLayoutPanelStatus.Controls.Add(this.flowLayoutPanel1, 3, 10);
            this.tableLayoutPanelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelStatus.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelStatus.Name = "tableLayoutPanelStatus";
            this.tableLayoutPanelStatus.RowCount = 13;
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelStatus.Size = new System.Drawing.Size(670, 455);
            this.tableLayoutPanelStatus.TabIndex = 60;
            // 
            // lblStatusImage
            // 
            this.lblStatusImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusImage.Image = ((System.Drawing.Image)(resources.GetObject("lblStatusImage.Image")));
            this.lblStatusImage.Location = new System.Drawing.Point(168, 0);
            this.lblStatusImage.Name = "lblStatusImage";
            this.tableLayoutPanelStatus.SetRowSpan(this.lblStatusImage, 12);
            this.lblStatusImage.Size = new System.Drawing.Size(284, 270);
            this.lblStatusImage.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label6.Location = new System.Drawing.Point(3, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "PCH Temp";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblT_SYS
            // 
            this.lblT_SYS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblT_SYS.AutoSize = true;
            this.lblT_SYS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_SYS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.lblT_SYS.Location = new System.Drawing.Point(95, 206);
            this.lblT_SYS.Margin = new System.Windows.Forms.Padding(0);
            this.lblT_SYS.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblT_SYS.Name = "lblT_SYS";
            this.lblT_SYS.Size = new System.Drawing.Size(54, 23);
            this.lblT_SYS.TabIndex = 11;
            this.lblT_SYS.Text = "000%";
            this.lblT_SYS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label5.Location = new System.Drawing.Point(3, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "GPU Util";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblP_GPU
            // 
            this.lblP_GPU.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblP_GPU.AutoSize = true;
            this.lblP_GPU.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP_GPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.lblP_GPU.Location = new System.Drawing.Point(95, 166);
            this.lblP_GPU.Margin = new System.Windows.Forms.Padding(0);
            this.lblP_GPU.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblP_GPU.Name = "lblP_GPU";
            this.lblP_GPU.Size = new System.Drawing.Size(54, 23);
            this.lblP_GPU.TabIndex = 10;
            this.lblP_GPU.Text = "000%";
            this.lblP_GPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblT_GPU
            // 
            this.lblT_GPU.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblT_GPU.AutoSize = true;
            this.lblT_GPU.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_GPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.lblT_GPU.Location = new System.Drawing.Point(95, 141);
            this.lblT_GPU.Margin = new System.Windows.Forms.Padding(0);
            this.lblT_GPU.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblT_GPU.Name = "lblT_GPU";
            this.lblT_GPU.Size = new System.Drawing.Size(54, 23);
            this.lblT_GPU.TabIndex = 9;
            this.lblT_GPU.Text = "000%";
            this.lblT_GPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "GPU Temp";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblP_CPU
            // 
            this.lblP_CPU.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblP_CPU.AutoSize = true;
            this.lblP_CPU.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP_CPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.lblP_CPU.Location = new System.Drawing.Point(95, 101);
            this.lblP_CPU.Margin = new System.Windows.Forms.Padding(0);
            this.lblP_CPU.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblP_CPU.Name = "lblP_CPU";
            this.lblP_CPU.Size = new System.Drawing.Size(54, 23);
            this.lblP_CPU.TabIndex = 8;
            this.lblP_CPU.Text = "000%";
            this.lblP_CPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPU Util";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPU Temp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblT_CPU
            // 
            this.lblT_CPU.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblT_CPU.AutoSize = true;
            this.lblT_CPU.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_CPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.lblT_CPU.Location = new System.Drawing.Point(95, 76);
            this.lblT_CPU.Margin = new System.Windows.Forms.Padding(0);
            this.lblT_CPU.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblT_CPU.Name = "lblT_CPU";
            this.lblT_CPU.Size = new System.Drawing.Size(54, 23);
            this.lblT_CPU.TabIndex = 7;
            this.lblT_CPU.Text = "000%";
            this.lblT_CPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "VRM Temp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblT_VRM
            // 
            this.lblT_VRM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblT_VRM.AutoSize = true;
            this.lblT_VRM.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_VRM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.lblT_VRM.Location = new System.Drawing.Point(95, 36);
            this.lblT_VRM.Margin = new System.Windows.Forms.Padding(0);
            this.lblT_VRM.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblT_VRM.Name = "lblT_VRM";
            this.lblT_VRM.Size = new System.Drawing.Size(54, 23);
            this.lblT_VRM.TabIndex = 6;
            this.lblT_VRM.Text = "000%";
            this.lblT_VRM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label8.Location = new System.Drawing.Point(458, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 57;
            this.label8.Text = "Radiator Fan (Pri)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // zedGTemps
            // 
            this.zedGTemps.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.zedGTemps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.tableLayoutPanelStatus.SetColumnSpan(this.zedGTemps, 5);
            this.zedGTemps.Location = new System.Drawing.Point(33, 275);
            this.zedGTemps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGTemps.Name = "zedGTemps";
            this.zedGTemps.ScrollGrace = 0D;
            this.zedGTemps.ScrollMaxX = 0D;
            this.zedGTemps.ScrollMaxY = 0D;
            this.zedGTemps.ScrollMaxY2 = 0D;
            this.zedGTemps.ScrollMinX = 0D;
            this.zedGTemps.ScrollMinY = 0D;
            this.zedGTemps.ScrollMinY2 = 0D;
            this.zedGTemps.Size = new System.Drawing.Size(604, 166);
            this.zedGTemps.TabIndex = 58;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanelStatus.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.btnLog);
            this.flowLayoutPanel1.Controls.Add(this.btnIface);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(458, 233);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanelStatus.SetRowSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(209, 34);
            this.flowLayoutPanel1.TabIndex = 60;
            // 
            // btnIface
            // 
            this.btnIface.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnIface.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnIface.FlatAppearance.BorderSize = 2;
            this.btnIface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIface.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIface.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btnIface.Location = new System.Drawing.Point(103, 3);
            this.btnIface.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnIface.Name = "btnIface";
            this.btnIface.Size = new System.Drawing.Size(87, 28);
            this.btnIface.TabIndex = 59;
            this.btnIface.Text = "Next Iface";
            this.btnIface.UseVisualStyleBackColor = false;
            this.btnIface.Click += new System.EventHandler(this.btnIface_Click);
            // 
            // managedPanelAlarms
            // 
            this.managedPanelAlarms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.managedPanelAlarms.Controls.Add(this.tableLayoutPanelAlarms);
            this.managedPanelAlarms.Location = new System.Drawing.Point(0, 0);
            this.managedPanelAlarms.Name = "managedPanelAlarms";
            this.managedPanelAlarms.Size = new System.Drawing.Size(0, 0);
            this.managedPanelAlarms.Text = "managedPanelAlarms";
            // 
            // tableLayoutPanelAlarms
            // 
            this.tableLayoutPanelAlarms.ColumnCount = 3;
            this.tableLayoutPanelAlarms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAlarms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAlarms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAlarms.Controls.Add(this.txtRad_A, 2, 8);
            this.tableLayoutPanelAlarms.Controls.Add(this.txtCaseT_A, 2, 7);
            this.tableLayoutPanelAlarms.Controls.Add(this.txtCASEB_A, 2, 6);
            this.tableLayoutPanelAlarms.Controls.Add(this.txtSYS_A, 2, 5);
            this.tableLayoutPanelAlarms.Controls.Add(this.txtGPU_A, 2, 4);
            this.tableLayoutPanelAlarms.Controls.Add(this.txtCPU_A, 2, 3);
            this.tableLayoutPanelAlarms.Controls.Add(this.txtVRM_A, 2, 2);
            this.tableLayoutPanelAlarms.Controls.Add(this.label34, 1, 9);
            this.tableLayoutPanelAlarms.Controls.Add(this.label33, 0, 9);
            this.tableLayoutPanelAlarms.Controls.Add(this.label32, 1, 8);
            this.tableLayoutPanelAlarms.Controls.Add(this.label31, 0, 8);
            this.tableLayoutPanelAlarms.Controls.Add(this.label30, 1, 7);
            this.tableLayoutPanelAlarms.Controls.Add(this.label29, 0, 7);
            this.tableLayoutPanelAlarms.Controls.Add(this.label28, 1, 6);
            this.tableLayoutPanelAlarms.Controls.Add(this.label27, 0, 6);
            this.tableLayoutPanelAlarms.Controls.Add(this.label26, 1, 5);
            this.tableLayoutPanelAlarms.Controls.Add(this.label22, 0, 5);
            this.tableLayoutPanelAlarms.Controls.Add(this.label21, 1, 4);
            this.tableLayoutPanelAlarms.Controls.Add(this.label20, 0, 4);
            this.tableLayoutPanelAlarms.Controls.Add(this.label19, 1, 3);
            this.tableLayoutPanelAlarms.Controls.Add(this.label18, 0, 3);
            this.tableLayoutPanelAlarms.Controls.Add(this.label17, 0, 2);
            this.tableLayoutPanelAlarms.Controls.Add(this.label16, 2, 1);
            this.tableLayoutPanelAlarms.Controls.Add(this.label15, 1, 1);
            this.tableLayoutPanelAlarms.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanelAlarms.Controls.Add(this.labelAlarmsTitle, 0, 0);
            this.tableLayoutPanelAlarms.Controls.Add(this.label9, 1, 2);
            this.tableLayoutPanelAlarms.Controls.Add(this.btnAlarms, 2, 10);
            this.tableLayoutPanelAlarms.Controls.Add(this.txtFlow_A, 2, 9);
            this.tableLayoutPanelAlarms.Location = new System.Drawing.Point(107, 15);
            this.tableLayoutPanelAlarms.Name = "tableLayoutPanelAlarms";
            this.tableLayoutPanelAlarms.RowCount = 11;
            this.tableLayoutPanelAlarms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelAlarms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelAlarms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelAlarms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelAlarms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelAlarms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelAlarms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelAlarms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelAlarms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelAlarms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelAlarms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelAlarms.Size = new System.Drawing.Size(449, 404);
            this.tableLayoutPanelAlarms.TabIndex = 36;
            // 
            // txtRad_A
            // 
            this.txtRad_A.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRad_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtRad_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRad_A.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRad_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtRad_A.Location = new System.Drawing.Point(315, 301);
            this.txtRad_A.Margin = new System.Windows.Forms.Padding(17, 6, 6, 6);
            this.txtRad_A.MaximumSize = new System.Drawing.Size(117, 24);
            this.txtRad_A.Name = "txtRad_A";
            this.txtRad_A.Size = new System.Drawing.Size(117, 26);
            this.txtRad_A.TabIndex = 61;
            this.txtRad_A.Text = "###";
            this.txtRad_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRad_A.WordWrap = false;
            this.txtRad_A.TextChanged += new System.EventHandler(this.txtAlarms_TextChanged);
            // 
            // txtCaseT_A
            // 
            this.txtCaseT_A.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCaseT_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtCaseT_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCaseT_A.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaseT_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtCaseT_A.Location = new System.Drawing.Point(315, 266);
            this.txtCaseT_A.Margin = new System.Windows.Forms.Padding(17, 6, 6, 6);
            this.txtCaseT_A.MaximumSize = new System.Drawing.Size(117, 24);
            this.txtCaseT_A.Name = "txtCaseT_A";
            this.txtCaseT_A.Size = new System.Drawing.Size(117, 26);
            this.txtCaseT_A.TabIndex = 60;
            this.txtCaseT_A.Text = "###";
            this.txtCaseT_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCaseT_A.WordWrap = false;
            this.txtCaseT_A.TextChanged += new System.EventHandler(this.txtAlarms_TextChanged);
            // 
            // txtCASEB_A
            // 
            this.txtCASEB_A.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCASEB_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtCASEB_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCASEB_A.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCASEB_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtCASEB_A.Location = new System.Drawing.Point(315, 231);
            this.txtCASEB_A.Margin = new System.Windows.Forms.Padding(17, 6, 6, 6);
            this.txtCASEB_A.MaximumSize = new System.Drawing.Size(117, 24);
            this.txtCASEB_A.Name = "txtCASEB_A";
            this.txtCASEB_A.Size = new System.Drawing.Size(117, 26);
            this.txtCASEB_A.TabIndex = 59;
            this.txtCASEB_A.Text = "###";
            this.txtCASEB_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCASEB_A.WordWrap = false;
            this.txtCASEB_A.TextChanged += new System.EventHandler(this.txtAlarms_TextChanged);
            // 
            // txtSYS_A
            // 
            this.txtSYS_A.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSYS_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtSYS_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSYS_A.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSYS_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtSYS_A.Location = new System.Drawing.Point(315, 196);
            this.txtSYS_A.Margin = new System.Windows.Forms.Padding(17, 6, 6, 6);
            this.txtSYS_A.MaximumSize = new System.Drawing.Size(117, 24);
            this.txtSYS_A.Name = "txtSYS_A";
            this.txtSYS_A.Size = new System.Drawing.Size(117, 26);
            this.txtSYS_A.TabIndex = 58;
            this.txtSYS_A.Text = "###";
            this.txtSYS_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSYS_A.WordWrap = false;
            this.txtSYS_A.TextChanged += new System.EventHandler(this.txtAlarms_TextChanged);
            // 
            // txtGPU_A
            // 
            this.txtGPU_A.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGPU_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtGPU_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGPU_A.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPU_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtGPU_A.Location = new System.Drawing.Point(315, 161);
            this.txtGPU_A.Margin = new System.Windows.Forms.Padding(17, 6, 6, 6);
            this.txtGPU_A.MaximumSize = new System.Drawing.Size(117, 24);
            this.txtGPU_A.Name = "txtGPU_A";
            this.txtGPU_A.Size = new System.Drawing.Size(117, 26);
            this.txtGPU_A.TabIndex = 57;
            this.txtGPU_A.Text = "###";
            this.txtGPU_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGPU_A.WordWrap = false;
            this.txtGPU_A.TextChanged += new System.EventHandler(this.txtAlarms_TextChanged);
            // 
            // txtCPU_A
            // 
            this.txtCPU_A.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCPU_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtCPU_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPU_A.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPU_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtCPU_A.Location = new System.Drawing.Point(315, 126);
            this.txtCPU_A.Margin = new System.Windows.Forms.Padding(17, 6, 6, 6);
            this.txtCPU_A.MaximumSize = new System.Drawing.Size(117, 24);
            this.txtCPU_A.Name = "txtCPU_A";
            this.txtCPU_A.Size = new System.Drawing.Size(117, 26);
            this.txtCPU_A.TabIndex = 56;
            this.txtCPU_A.Text = "###";
            this.txtCPU_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPU_A.WordWrap = false;
            this.txtCPU_A.TextChanged += new System.EventHandler(this.txtAlarms_TextChanged);
            // 
            // txtVRM_A
            // 
            this.txtVRM_A.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVRM_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtVRM_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVRM_A.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVRM_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtVRM_A.Location = new System.Drawing.Point(315, 91);
            this.txtVRM_A.Margin = new System.Windows.Forms.Padding(17, 6, 6, 6);
            this.txtVRM_A.MaximumSize = new System.Drawing.Size(117, 24);
            this.txtVRM_A.Name = "txtVRM_A";
            this.txtVRM_A.Size = new System.Drawing.Size(117, 26);
            this.txtVRM_A.TabIndex = 55;
            this.txtVRM_A.Text = "###";
            this.txtVRM_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVRM_A.WordWrap = false;
            this.txtVRM_A.TextChanged += new System.EventHandler(this.txtAlarms_TextChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label34.Location = new System.Drawing.Point(152, 330);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(143, 35);
            this.label34.TabIndex = 54;
            this.label34.Text = "LOW (L/h)";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label33.Location = new System.Drawing.Point(3, 330);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(143, 35);
            this.label33.TabIndex = 53;
            this.label33.Text = "Water Flow";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label32.Location = new System.Drawing.Point(152, 295);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(143, 35);
            this.label32.TabIndex = 52;
            this.label32.Text = "HIGH (°C)";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label31.Location = new System.Drawing.Point(3, 295);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(143, 35);
            this.label31.TabIndex = 51;
            this.label31.Text = "Water Temp";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label30.Location = new System.Drawing.Point(152, 260);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(143, 35);
            this.label30.TabIndex = 50;
            this.label30.Text = "HIGH (°C)";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label29.Location = new System.Drawing.Point(3, 260);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(143, 35);
            this.label29.TabIndex = 49;
            this.label29.Text = "Case Bottom Temp";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label28.Location = new System.Drawing.Point(152, 225);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(143, 35);
            this.label28.TabIndex = 48;
            this.label28.Text = "HIGH (°C)";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label27.Location = new System.Drawing.Point(3, 225);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(143, 35);
            this.label27.TabIndex = 47;
            this.label27.Text = "Case Top Temp";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label26.Location = new System.Drawing.Point(152, 190);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(143, 35);
            this.label26.TabIndex = 46;
            this.label26.Text = "HIGH (°C)";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label22.Location = new System.Drawing.Point(3, 190);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(143, 35);
            this.label22.TabIndex = 45;
            this.label22.Text = "PCH Temp";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label21.Location = new System.Drawing.Point(152, 155);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(143, 35);
            this.label21.TabIndex = 44;
            this.label21.Text = "HIGH (°C)";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label20.Location = new System.Drawing.Point(3, 155);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(143, 35);
            this.label20.TabIndex = 43;
            this.label20.Text = "GPU Temp";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label19.Location = new System.Drawing.Point(152, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(143, 35);
            this.label19.TabIndex = 42;
            this.label19.Text = "HIGH (°C)";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label18.Location = new System.Drawing.Point(3, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 35);
            this.label18.TabIndex = 41;
            this.label18.Text = "CPU Temp";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label17.Location = new System.Drawing.Point(3, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 35);
            this.label17.TabIndex = 40;
            this.label17.Text = "VRM Temp";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label16.Location = new System.Drawing.Point(301, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 40);
            this.label16.TabIndex = 39;
            this.label16.Text = "Alarm Limit";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label15.Location = new System.Drawing.Point(152, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 40);
            this.label15.TabIndex = 38;
            this.label15.Text = "Alarm Type (Unit)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label14.Location = new System.Drawing.Point(3, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 40);
            this.label14.TabIndex = 37;
            this.label14.Text = "Measurement";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label9.Location = new System.Drawing.Point(152, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 35);
            this.label9.TabIndex = 36;
            this.label9.Text = "HIGH (°C)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlarms
            // 
            this.btnAlarms.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAlarms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnAlarms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnAlarms.FlatAppearance.BorderSize = 2;
            this.btnAlarms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarms.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btnAlarms.Location = new System.Drawing.Point(315, 371);
            this.btnAlarms.Margin = new System.Windows.Forms.Padding(17, 6, 6, 6);
            this.btnAlarms.Name = "btnAlarms";
            this.btnAlarms.Size = new System.Drawing.Size(117, 27);
            this.btnAlarms.TabIndex = 63;
            this.btnAlarms.Text = "Write Alarms";
            this.btnAlarms.UseVisualStyleBackColor = false;
            this.btnAlarms.Click += new System.EventHandler(this.btnAlarms_Click);
            // 
            // txtFlow_A
            // 
            this.txtFlow_A.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFlow_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtFlow_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFlow_A.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlow_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtFlow_A.Location = new System.Drawing.Point(315, 336);
            this.txtFlow_A.Margin = new System.Windows.Forms.Padding(17, 6, 6, 6);
            this.txtFlow_A.MaximumSize = new System.Drawing.Size(117, 24);
            this.txtFlow_A.Name = "txtFlow_A";
            this.txtFlow_A.Size = new System.Drawing.Size(117, 26);
            this.txtFlow_A.TabIndex = 62;
            this.txtFlow_A.Text = "###";
            this.txtFlow_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFlow_A.WordWrap = false;
            this.txtFlow_A.TextChanged += new System.EventHandler(this.txtAlarms_TextChanged);
            // 
            // managedPanelFans
            // 
            this.managedPanelFans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.managedPanelFans.Controls.Add(this.tableLayoutPanelFans);
            this.managedPanelFans.Location = new System.Drawing.Point(0, 0);
            this.managedPanelFans.Name = "managedPanelFans";
            this.managedPanelFans.Size = new System.Drawing.Size(0, 0);
            this.managedPanelFans.Text = "managedPanelFans";
            this.managedPanelFans.VisibleChanged += new System.EventHandler(this.managedPanelFans_VisibleChanged);
            // 
            // tableLayoutPanelFans
            // 
            this.tableLayoutPanelFans.ColumnCount = 6;
            this.tableLayoutPanelFans.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelFans.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanelFans.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFans.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanelFans.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFans.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanelFans.Controls.Add(this.label45, 2, 3);
            this.tableLayoutPanelFans.Controls.Add(this.txtFan3Hys, 5, 5);
            this.tableLayoutPanelFans.Controls.Add(this.label37, 4, 0);
            this.tableLayoutPanelFans.Controls.Add(this.label36, 2, 0);
            this.tableLayoutPanelFans.Controls.Add(this.label35, 0, 0);
            this.tableLayoutPanelFans.Controls.Add(this.label38, 0, 1);
            this.tableLayoutPanelFans.Controls.Add(this.label39, 0, 2);
            this.tableLayoutPanelFans.Controls.Add(this.label40, 0, 3);
            this.tableLayoutPanelFans.Controls.Add(this.label41, 0, 4);
            this.tableLayoutPanelFans.Controls.Add(this.label42, 0, 5);
            this.tableLayoutPanelFans.Controls.Add(this.label43, 2, 1);
            this.tableLayoutPanelFans.Controls.Add(this.label44, 2, 2);
            this.tableLayoutPanelFans.Controls.Add(this.label46, 2, 4);
            this.tableLayoutPanelFans.Controls.Add(this.label47, 2, 5);
            this.tableLayoutPanelFans.Controls.Add(this.label48, 4, 1);
            this.tableLayoutPanelFans.Controls.Add(this.label52, 4, 5);
            this.tableLayoutPanelFans.Controls.Add(this.label49, 4, 2);
            this.tableLayoutPanelFans.Controls.Add(this.label50, 4, 3);
            this.tableLayoutPanelFans.Controls.Add(this.label51, 4, 4);
            this.tableLayoutPanelFans.Controls.Add(this.txtFan2HighT, 3, 2);
            this.tableLayoutPanelFans.Controls.Add(this.txtFan1Hys, 1, 5);
            this.tableLayoutPanelFans.Controls.Add(this.txtFan2Hys, 3, 5);
            this.tableLayoutPanelFans.Controls.Add(this.txtFan1LowT, 1, 1);
            this.tableLayoutPanelFans.Controls.Add(this.txtFan1LowO, 1, 3);
            this.tableLayoutPanelFans.Controls.Add(this.txtFan1HighT, 1, 2);
            this.tableLayoutPanelFans.Controls.Add(this.txtFan3LowO, 5, 3);
            this.tableLayoutPanelFans.Controls.Add(this.txtFan3HighT, 5, 2);
            this.tableLayoutPanelFans.Controls.Add(this.txtFan3HighO, 5, 4);
            this.tableLayoutPanelFans.Controls.Add(this.txtFan3LowT, 5, 1);
            this.tableLayoutPanelFans.Controls.Add(this.txtFan2HighO, 3, 4);
            this.tableLayoutPanelFans.Controls.Add(this.txtFan2LowO, 3, 3);
            this.tableLayoutPanelFans.Controls.Add(this.txtFan2LowT, 3, 1);
            this.tableLayoutPanelFans.Controls.Add(this.txtFan1HighO, 1, 4);
            this.tableLayoutPanelFans.Controls.Add(this.btnFan, 5, 6);
            this.tableLayoutPanelFans.Controls.Add(this.zedGFan, 0, 6);
            this.tableLayoutPanelFans.Location = new System.Drawing.Point(20, 0);
            this.tableLayoutPanelFans.Name = "tableLayoutPanelFans";
            this.tableLayoutPanelFans.RowCount = 8;
            this.tableLayoutPanelFans.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelFans.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelFans.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelFans.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelFans.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelFans.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelFans.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelFans.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFans.Size = new System.Drawing.Size(630, 446);
            this.tableLayoutPanelFans.TabIndex = 0;
            // 
            // label45
            // 
            this.label45.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label45.Location = new System.Drawing.Point(207, 110);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(65, 30);
            this.label45.TabIndex = 59;
            this.label45.Text = "Fan 2 Low Output";
            // 
            // txtFan3Hys
            // 
            this.txtFan3Hys.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFan3Hys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtFan3Hys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFan3Hys.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFan3Hys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtFan3Hys.Location = new System.Drawing.Point(518, 176);
            this.txtFan3Hys.Name = "txtFan3Hys";
            this.txtFan3Hys.Size = new System.Drawing.Size(91, 26);
            this.txtFan3Hys.TabIndex = 81;
            this.txtFan3Hys.Text = "###";
            this.txtFan3Hys.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFan3Hys.TextChanged += new System.EventHandler(this.TextFan_TextChanged);
            this.txtFan3Hys.Leave += new System.EventHandler(this.TextFan_Leave);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.tableLayoutPanelFans.SetColumnSpan(this.label37, 2);
            this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label37.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.label37.Location = new System.Drawing.Point(410, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(217, 45);
            this.label37.TabIndex = 2;
            this.label37.Text = "Fan 3 (F_AON)";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.tableLayoutPanelFans.SetColumnSpan(this.label36, 2);
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.label36.Location = new System.Drawing.Point(207, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(197, 45);
            this.label36.TabIndex = 1;
            this.label36.Text = "Fan 2 (F_TOP)";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.tableLayoutPanelFans.SetColumnSpan(this.label35, 2);
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.label35.Location = new System.Drawing.Point(3, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(198, 45);
            this.label35.TabIndex = 0;
            this.label35.Text = "Fan 1 (F_RAD)";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label38.Location = new System.Drawing.Point(3, 53);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(95, 15);
            this.label38.TabIndex = 52;
            this.label38.Text = "Fan 1 Low Temp";
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label39.Location = new System.Drawing.Point(3, 85);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(96, 15);
            this.label39.TabIndex = 53;
            this.label39.Text = "Fan 1 High Temp";
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label40.Location = new System.Drawing.Point(3, 110);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(65, 30);
            this.label40.TabIndex = 54;
            this.label40.Text = "Fan 1 Low Output";
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label41.Location = new System.Drawing.Point(3, 142);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(66, 30);
            this.label41.TabIndex = 55;
            this.label41.Text = "Fan 1 High Output";
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label42.Location = new System.Drawing.Point(3, 181);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(95, 15);
            this.label42.TabIndex = 56;
            this.label42.Text = "Fan 1 Hysteresis";
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label43.Location = new System.Drawing.Point(207, 53);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(95, 15);
            this.label43.TabIndex = 57;
            this.label43.Text = "Fan 2 Low Temp";
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label44.Location = new System.Drawing.Point(207, 85);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(96, 15);
            this.label44.TabIndex = 58;
            this.label44.Text = "Fan 2 High Temp";
            // 
            // label46
            // 
            this.label46.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label46.Location = new System.Drawing.Point(207, 142);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(66, 30);
            this.label46.TabIndex = 60;
            this.label46.Text = "Fan 2 High Output";
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label47.Location = new System.Drawing.Point(207, 181);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(95, 15);
            this.label47.TabIndex = 61;
            this.label47.Text = "Fan 2 Hysteresis";
            // 
            // label48
            // 
            this.label48.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label48.Location = new System.Drawing.Point(410, 53);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(95, 15);
            this.label48.TabIndex = 72;
            this.label48.Text = "Fan 3 Low Temp";
            // 
            // label52
            // 
            this.label52.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label52.Location = new System.Drawing.Point(410, 181);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(95, 15);
            this.label52.TabIndex = 76;
            this.label52.Text = "Fan 3 Hysteresis";
            // 
            // label49
            // 
            this.label49.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label49.Location = new System.Drawing.Point(410, 85);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(96, 15);
            this.label49.TabIndex = 73;
            this.label49.Text = "Fan 3 High Temp";
            // 
            // label50
            // 
            this.label50.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label50.Location = new System.Drawing.Point(410, 110);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(65, 30);
            this.label50.TabIndex = 74;
            this.label50.Text = "Fan 3 Low Output";
            // 
            // label51
            // 
            this.label51.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label51.Location = new System.Drawing.Point(410, 142);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(66, 30);
            this.label51.TabIndex = 75;
            this.label51.Text = "Fan 3 High Output";
            // 
            // txtFan2HighT
            // 
            this.txtFan2HighT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFan2HighT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtFan2HighT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFan2HighT.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFan2HighT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtFan2HighT.Location = new System.Drawing.Point(315, 80);
            this.txtFan2HighT.Name = "txtFan2HighT";
            this.txtFan2HighT.Size = new System.Drawing.Size(89, 26);
            this.txtFan2HighT.TabIndex = 70;
            this.txtFan2HighT.Text = "###";
            this.txtFan2HighT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFan2HighT.TextChanged += new System.EventHandler(this.TextFan_TextChanged);
            this.txtFan2HighT.Leave += new System.EventHandler(this.TextFan_Leave);
            // 
            // txtFan1Hys
            // 
            this.txtFan1Hys.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFan1Hys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtFan1Hys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFan1Hys.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFan1Hys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtFan1Hys.Location = new System.Drawing.Point(112, 176);
            this.txtFan1Hys.Name = "txtFan1Hys";
            this.txtFan1Hys.Size = new System.Drawing.Size(89, 26);
            this.txtFan1Hys.TabIndex = 68;
            this.txtFan1Hys.Text = "###";
            this.txtFan1Hys.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFan1Hys.TextChanged += new System.EventHandler(this.TextFan_TextChanged);
            this.txtFan1Hys.Leave += new System.EventHandler(this.TextFan_Leave);
            // 
            // txtFan2Hys
            // 
            this.txtFan2Hys.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFan2Hys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtFan2Hys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFan2Hys.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFan2Hys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtFan2Hys.Location = new System.Drawing.Point(315, 176);
            this.txtFan2Hys.Name = "txtFan2Hys";
            this.txtFan2Hys.Size = new System.Drawing.Size(89, 26);
            this.txtFan2Hys.TabIndex = 64;
            this.txtFan2Hys.Text = "###";
            this.txtFan2Hys.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFan2Hys.TextChanged += new System.EventHandler(this.TextFan_TextChanged);
            this.txtFan2Hys.Leave += new System.EventHandler(this.TextFan_Leave);
            // 
            // txtFan1LowT
            // 
            this.txtFan1LowT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFan1LowT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtFan1LowT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFan1LowT.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFan1LowT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtFan1LowT.Location = new System.Drawing.Point(112, 48);
            this.txtFan1LowT.Name = "txtFan1LowT";
            this.txtFan1LowT.Size = new System.Drawing.Size(89, 26);
            this.txtFan1LowT.TabIndex = 62;
            this.txtFan1LowT.Text = "###";
            this.txtFan1LowT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFan1LowT.TextChanged += new System.EventHandler(this.TextFan_TextChanged);
            this.txtFan1LowT.Leave += new System.EventHandler(this.TextFan_Leave);
            // 
            // txtFan1LowO
            // 
            this.txtFan1LowO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFan1LowO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtFan1LowO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFan1LowO.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFan1LowO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtFan1LowO.Location = new System.Drawing.Point(112, 112);
            this.txtFan1LowO.Name = "txtFan1LowO";
            this.txtFan1LowO.Size = new System.Drawing.Size(89, 26);
            this.txtFan1LowO.TabIndex = 66;
            this.txtFan1LowO.Text = "###";
            this.txtFan1LowO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFan1LowO.TextChanged += new System.EventHandler(this.TextFan_TextChanged);
            this.txtFan1LowO.Leave += new System.EventHandler(this.TextFan_Leave);
            // 
            // txtFan1HighT
            // 
            this.txtFan1HighT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFan1HighT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtFan1HighT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFan1HighT.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFan1HighT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtFan1HighT.Location = new System.Drawing.Point(112, 80);
            this.txtFan1HighT.Name = "txtFan1HighT";
            this.txtFan1HighT.Size = new System.Drawing.Size(89, 26);
            this.txtFan1HighT.TabIndex = 65;
            this.txtFan1HighT.Text = "###";
            this.txtFan1HighT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFan1HighT.TextChanged += new System.EventHandler(this.TextFan_TextChanged);
            this.txtFan1HighT.Leave += new System.EventHandler(this.TextFan_Leave);
            // 
            // txtFan3LowO
            // 
            this.txtFan3LowO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFan3LowO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtFan3LowO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFan3LowO.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFan3LowO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtFan3LowO.Location = new System.Drawing.Point(518, 112);
            this.txtFan3LowO.Name = "txtFan3LowO";
            this.txtFan3LowO.Size = new System.Drawing.Size(91, 26);
            this.txtFan3LowO.TabIndex = 79;
            this.txtFan3LowO.Text = "###";
            this.txtFan3LowO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFan3LowO.TextChanged += new System.EventHandler(this.TextFan_TextChanged);
            this.txtFan3LowO.Leave += new System.EventHandler(this.TextFan_Leave);
            // 
            // txtFan3HighT
            // 
            this.txtFan3HighT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFan3HighT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtFan3HighT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFan3HighT.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFan3HighT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtFan3HighT.Location = new System.Drawing.Point(518, 80);
            this.txtFan3HighT.Name = "txtFan3HighT";
            this.txtFan3HighT.Size = new System.Drawing.Size(91, 26);
            this.txtFan3HighT.TabIndex = 78;
            this.txtFan3HighT.Text = "###";
            this.txtFan3HighT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFan3HighT.TextChanged += new System.EventHandler(this.TextFan_TextChanged);
            this.txtFan3HighT.Leave += new System.EventHandler(this.TextFan_Leave);
            // 
            // txtFan3HighO
            // 
            this.txtFan3HighO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFan3HighO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtFan3HighO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFan3HighO.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFan3HighO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtFan3HighO.Location = new System.Drawing.Point(518, 144);
            this.txtFan3HighO.Name = "txtFan3HighO";
            this.txtFan3HighO.Size = new System.Drawing.Size(91, 26);
            this.txtFan3HighO.TabIndex = 80;
            this.txtFan3HighO.Text = "###";
            this.txtFan3HighO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFan3HighO.TextChanged += new System.EventHandler(this.TextFan_TextChanged);
            this.txtFan3HighO.Leave += new System.EventHandler(this.TextFan_Leave);
            // 
            // txtFan3LowT
            // 
            this.txtFan3LowT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFan3LowT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtFan3LowT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFan3LowT.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFan3LowT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtFan3LowT.Location = new System.Drawing.Point(518, 48);
            this.txtFan3LowT.Name = "txtFan3LowT";
            this.txtFan3LowT.Size = new System.Drawing.Size(91, 26);
            this.txtFan3LowT.TabIndex = 77;
            this.txtFan3LowT.Text = "###";
            this.txtFan3LowT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFan3LowT.TextChanged += new System.EventHandler(this.TextFan_TextChanged);
            this.txtFan3LowT.Leave += new System.EventHandler(this.TextFan_Leave);
            // 
            // txtFan2HighO
            // 
            this.txtFan2HighO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFan2HighO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtFan2HighO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFan2HighO.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFan2HighO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtFan2HighO.Location = new System.Drawing.Point(315, 144);
            this.txtFan2HighO.Name = "txtFan2HighO";
            this.txtFan2HighO.Size = new System.Drawing.Size(89, 26);
            this.txtFan2HighO.TabIndex = 63;
            this.txtFan2HighO.Text = "###";
            this.txtFan2HighO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFan2HighO.TextChanged += new System.EventHandler(this.TextFan_TextChanged);
            this.txtFan2HighO.Leave += new System.EventHandler(this.TextFan_Leave);
            // 
            // txtFan2LowO
            // 
            this.txtFan2LowO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFan2LowO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtFan2LowO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFan2LowO.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFan2LowO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtFan2LowO.Location = new System.Drawing.Point(315, 112);
            this.txtFan2LowO.Name = "txtFan2LowO";
            this.txtFan2LowO.Size = new System.Drawing.Size(89, 26);
            this.txtFan2LowO.TabIndex = 71;
            this.txtFan2LowO.Text = "###";
            this.txtFan2LowO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFan2LowO.TextChanged += new System.EventHandler(this.TextFan_TextChanged);
            this.txtFan2LowO.Leave += new System.EventHandler(this.TextFan_Leave);
            // 
            // txtFan2LowT
            // 
            this.txtFan2LowT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFan2LowT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtFan2LowT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFan2LowT.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFan2LowT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtFan2LowT.Location = new System.Drawing.Point(315, 48);
            this.txtFan2LowT.Name = "txtFan2LowT";
            this.txtFan2LowT.Size = new System.Drawing.Size(89, 26);
            this.txtFan2LowT.TabIndex = 69;
            this.txtFan2LowT.Text = "###";
            this.txtFan2LowT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFan2LowT.TextChanged += new System.EventHandler(this.TextFan_TextChanged);
            this.txtFan2LowT.Leave += new System.EventHandler(this.TextFan_Leave);
            // 
            // txtFan1HighO
            // 
            this.txtFan1HighO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFan1HighO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txtFan1HighO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFan1HighO.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFan1HighO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(106)))));
            this.txtFan1HighO.Location = new System.Drawing.Point(112, 144);
            this.txtFan1HighO.Name = "txtFan1HighO";
            this.txtFan1HighO.Size = new System.Drawing.Size(89, 26);
            this.txtFan1HighO.TabIndex = 67;
            this.txtFan1HighO.Text = "###";
            this.txtFan1HighO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFan1HighO.TextChanged += new System.EventHandler(this.TextFan_TextChanged);
            this.txtFan1HighO.Leave += new System.EventHandler(this.TextFan_Leave);
            // 
            // btnFan
            // 
            this.btnFan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnFan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnFan.FlatAppearance.BorderSize = 2;
            this.btnFan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFan.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btnFan.Location = new System.Drawing.Point(518, 208);
            this.btnFan.Name = "btnFan";
            this.btnFan.Size = new System.Drawing.Size(91, 28);
            this.btnFan.TabIndex = 82;
            this.btnFan.Text = "Write Fan";
            this.btnFan.UseVisualStyleBackColor = false;
            this.btnFan.Click += new System.EventHandler(this.btnFan_Click);
            // 
            // zedGFan
            // 
            this.zedGFan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanelFans.SetColumnSpan(this.zedGFan, 5);
            this.zedGFan.IsEnableHPan = false;
            this.zedGFan.IsEnableHZoom = false;
            this.zedGFan.IsEnableVPan = false;
            this.zedGFan.IsEnableVZoom = false;
            this.zedGFan.IsEnableWheelZoom = false;
            this.zedGFan.IsPrintFillPage = false;
            this.zedGFan.IsPrintKeepAspectRatio = false;
            this.zedGFan.IsPrintScaleAll = false;
            this.zedGFan.IsShowPointValues = true;
            this.zedGFan.Location = new System.Drawing.Point(46, 210);
            this.zedGFan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGFan.Name = "zedGFan";
            this.tableLayoutPanelFans.SetRowSpan(this.zedGFan, 2);
            this.zedGFan.ScrollGrace = 0D;
            this.zedGFan.ScrollMaxX = 0D;
            this.zedGFan.ScrollMaxY = 0D;
            this.zedGFan.ScrollMaxY2 = 0D;
            this.zedGFan.ScrollMinX = 0D;
            this.zedGFan.ScrollMinY = 0D;
            this.zedGFan.ScrollMinY2 = 0D;
            this.zedGFan.Size = new System.Drawing.Size(422, 230);
            this.zedGFan.TabIndex = 83;
            // 
            // managedPanelCtrl
            // 
            this.managedPanelCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.managedPanelCtrl.Controls.Add(this.tableLayoutPanelDebug);
            this.managedPanelCtrl.Location = new System.Drawing.Point(0, 0);
            this.managedPanelCtrl.Name = "managedPanelCtrl";
            this.managedPanelCtrl.Size = new System.Drawing.Size(0, 0);
            this.managedPanelCtrl.Text = "managedPanelCtrl";
            // 
            // tableLayoutPanelDebug
            // 
            this.tableLayoutPanelDebug.AutoSize = true;
            this.tableLayoutPanelDebug.ColumnCount = 2;
            this.tableLayoutPanelDebug.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.63527F));
            this.tableLayoutPanelDebug.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.36473F));
            this.tableLayoutPanelDebug.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanelDebug.Controls.Add(this.paneltxtRecvBorder, 1, 1);
            this.tableLayoutPanelDebug.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanelDebug.Controls.Add(this.paneltxtSendBorder, 1, 3);
            this.tableLayoutPanelDebug.Controls.Add(this.tableLayoutPanelControl, 1, 0);
            this.tableLayoutPanelDebug.Location = new System.Drawing.Point(36, 37);
            this.tableLayoutPanelDebug.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelDebug.Name = "tableLayoutPanelDebug";
            this.tableLayoutPanelDebug.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanelDebug.RowCount = 4;
            this.tableLayoutPanelDebug.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelDebug.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanelDebug.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanelDebug.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDebug.Size = new System.Drawing.Size(781, 381);
            this.tableLayoutPanelDebug.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label11.Location = new System.Drawing.Point(4, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Send Value:";
            // 
            // paneltxtRecvBorder
            // 
            this.paneltxtRecvBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.paneltxtRecvBorder.Controls.Add(this.txtSend);
            this.paneltxtRecvBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltxtRecvBorder.Location = new System.Drawing.Point(138, 51);
            this.paneltxtRecvBorder.Margin = new System.Windows.Forms.Padding(0);
            this.paneltxtRecvBorder.Name = "paneltxtRecvBorder";
            this.paneltxtRecvBorder.Padding = new System.Windows.Forms.Padding(2);
            this.paneltxtRecvBorder.Size = new System.Drawing.Size(642, 118);
            this.paneltxtRecvBorder.TabIndex = 4;
            // 
            // txtSend
            // 
            this.txtSend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.txtSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.txtSend.Location = new System.Drawing.Point(2, 2);
            this.txtSend.Margin = new System.Windows.Forms.Padding(4);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ReadOnly = true;
            this.txtSend.Size = new System.Drawing.Size(492, 114);
            this.txtSend.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(161)))));
            this.label13.Location = new System.Drawing.Point(4, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Receive Value:";
            // 
            // paneltxtSendBorder
            // 
            this.paneltxtSendBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.paneltxtSendBorder.Controls.Add(this.txtReceive);
            this.paneltxtSendBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltxtSendBorder.Location = new System.Drawing.Point(138, 173);
            this.paneltxtSendBorder.Margin = new System.Windows.Forms.Padding(0);
            this.paneltxtSendBorder.Name = "paneltxtSendBorder";
            this.paneltxtSendBorder.Size = new System.Drawing.Size(642, 207);
            this.paneltxtSendBorder.TabIndex = 5;
            // 
            // txtReceive
            // 
            this.txtReceive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.txtReceive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.txtReceive.Location = new System.Drawing.Point(2, 2);
            this.txtReceive.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.Size = new System.Drawing.Size(492, 203);
            this.txtReceive.TabIndex = 3;
            // 
            // tableLayoutPanelControl
            // 
            this.tableLayoutPanelControl.ColumnCount = 5;
            this.tableLayoutPanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelControl.Controls.Add(this.cmbPortName, 0, 0);
            this.tableLayoutPanelControl.Controls.Add(this.btnReset, 4, 0);
            this.tableLayoutPanelControl.Controls.Add(this.btnCOMRefresh, 1, 0);
            this.tableLayoutPanelControl.Controls.Add(this.btnConnect, 2, 0);
            this.tableLayoutPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelControl.Location = new System.Drawing.Point(141, 4);
            this.tableLayoutPanelControl.Name = "tableLayoutPanelControl";
            this.tableLayoutPanelControl.RowCount = 1;
            this.tableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelControl.Size = new System.Drawing.Size(636, 44);
            this.tableLayoutPanelControl.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btnReset.Location = new System.Drawing.Point(511, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 28);
            this.btnReset.TabIndex = 55;
            this.btnReset.Text = "Reset Controller";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCOMRefresh
            // 
            this.btnCOMRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnCOMRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnCOMRefresh.FlatAppearance.BorderSize = 2;
            this.btnCOMRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOMRefresh.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOMRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btnCOMRefresh.Location = new System.Drawing.Point(130, 3);
            this.btnCOMRefresh.Name = "btnCOMRefresh";
            this.btnCOMRefresh.Size = new System.Drawing.Size(87, 28);
            this.btnCOMRefresh.TabIndex = 54;
            this.btnCOMRefresh.Text = "Refresh";
            this.btnCOMRefresh.UseVisualStyleBackColor = false;
            this.btnCOMRefresh.Click += new System.EventHandler(this.btnCOMRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.tableLayoutPanelBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fan Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanelBack.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.tableLayoutPanelTitleBar.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.tableLayoutPanelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelManager1.ResumeLayout(false);
            this.managedPanelStatus.ResumeLayout(false);
            this.tableLayoutPanelStatus.ResumeLayout(false);
            this.tableLayoutPanelStatus.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.managedPanelAlarms.ResumeLayout(false);
            this.tableLayoutPanelAlarms.ResumeLayout(false);
            this.tableLayoutPanelAlarms.PerformLayout();
            this.managedPanelFans.ResumeLayout(false);
            this.tableLayoutPanelFans.ResumeLayout(false);
            this.tableLayoutPanelFans.PerformLayout();
            this.managedPanelCtrl.ResumeLayout(false);
            this.managedPanelCtrl.PerformLayout();
            this.tableLayoutPanelDebug.ResumeLayout(false);
            this.tableLayoutPanelDebug.PerformLayout();
            this.paneltxtRecvBorder.ResumeLayout(false);
            this.paneltxtRecvBorder.PerformLayout();
            this.paneltxtSendBorder.ResumeLayout(false);
            this.paneltxtSendBorder.PerformLayout();
            this.tableLayoutPanelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.Timer tmrUpdate;

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUI;
        private System.Windows.Forms.Label labelAlarmsTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblT_CASEB;
        private System.Windows.Forms.Label lblT_CASET;
        private System.Windows.Forms.Label lblF_CASET;
        private System.Windows.Forms.Label lblT_RAD;
        private System.Windows.Forms.Label lblF_RAD;
        private System.Windows.Forms.Label lblFLOW;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblF_AON;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBack;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenu;
        private System.Windows.Forms.Button btnMenuStatus;
        private Controls.PanelManager panelManager1;
        private Controls.ManagedPanel managedPanelStatus;
        private Controls.ManagedPanel managedPanelFans;
        private Controls.ManagedPanel managedPanelAlarms;
        private Controls.ManagedPanel managedPanelCtrl;
        private System.Windows.Forms.Button btnMenuController;
        private System.Windows.Forms.Button btnMenuAlarms;
        private System.Windows.Forms.Button btnMenuFans;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTitleBar;
        private System.Windows.Forms.Button btnConnect2;
        private System.Windows.Forms.Button btnMinimise;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLogoImage;
        private System.Windows.Forms.Label lblLogoText;
        private System.Windows.Forms.Label lblStatusImage;
        private System.Windows.Forms.Label lblT_CPU;
        private System.Windows.Forms.Label lblP_CPU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblP_GPU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblT_SYS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblT_GPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblT_VRM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIface;
        private ZedGraph.ZedGraphControl zedGTemps;
        private System.Windows.Forms.Button btnCOMRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDebug;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Panel paneltxtRecvBorder;
        private System.Windows.Forms.Panel paneltxtSendBorder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAlarms;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVRM_A;
        private System.Windows.Forms.TextBox txtCPU_A;
        private System.Windows.Forms.TextBox txtGPU_A;
        private System.Windows.Forms.TextBox txtSYS_A;
        private System.Windows.Forms.TextBox txtCASEB_A;
        private System.Windows.Forms.TextBox txtCaseT_A;
        private System.Windows.Forms.TextBox txtRad_A;
        private System.Windows.Forms.TextBox txtFlow_A;
        private System.Windows.Forms.Button btnAlarms;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFans;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtFan2HighT;
        private System.Windows.Forms.TextBox txtFan2LowT;
        private System.Windows.Forms.TextBox txtFan1Hys;
        private System.Windows.Forms.TextBox txtFan1HighO;
        private System.Windows.Forms.TextBox txtFan1LowO;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txtFan1LowT;
        private System.Windows.Forms.TextBox txtFan2Hys;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtFan3LowT;
        private System.Windows.Forms.TextBox txtFan3HighT;
        private System.Windows.Forms.TextBox txtFan3LowO;
        private System.Windows.Forms.TextBox txtFan3HighO;
        private System.Windows.Forms.TextBox txtFan3Hys;
        private System.Windows.Forms.TextBox txtFan2LowO;
        private System.Windows.Forms.TextBox txtFan1HighT;
        private System.Windows.Forms.TextBox txtFan2HighO;
        private System.Windows.Forms.Button btnFan;
        private ZedGraph.ZedGraphControl zedGFan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

