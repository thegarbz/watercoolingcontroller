#include "DEV_Config.h"
#include "LCD_Driver.h"
#include "LCD_GUI.h"
#include "LCD_Bmp.h"
#include "Debug.h"
#include "Fan_control_2.h"
#include "variables.h"
#include "fan.h"
#include "comms.h"
#include "draw_display.h"


uint32_t timer = 0;
uint32_t timer_disp_update = 0;
uint32_t timer_rpm = 0;
uint16_t rpm_pulse = 0;

/*
 * Initial function - Executed after reset.
 * Setup system. Set default fan speed to 30%. Read settings from SD card.
 * Draw the background for the current interface.
 */
void setup(void)
{
  for (int i=0; i < GRAPH_LENGTH; i++)
    history[i] = 1;
  pinMode(11, INPUT_PULLUP); //D2 Interrupt for PWM measurement
  attachInterrupt(digitalPinToInterrupt(11), pin11Interrupt, FALLING);
  delay(2000);
  System_Init();
  FanPWM_Init();
  FanPWM_Set(FAN_RAD, 30);
  FanPWM_Set(FAN_TOP, 30);
  FanPWM_Set(FAN_AON, 30);
  analogReference(AR_DEFAULT);

  DEBUG("SD_Init \n");
  SD_Init();

  DEBUG("Reading Settings\n");
  Settings_Read();

  DEBUG("LCD Init \n");
  LCD_SCAN_DIR Lcd_ScanDir = SCAN_DIR_DFT;
  LCD_Init(Lcd_ScanDir, 255);

  DEBUG("Interface \n");
  DEBUG(interface);
  LCD_ShowBackground(interface);
  interface_prev = interface;

  command = "";
  commandsend = "";
  timer = millis();
}

/*
 * Primary Loop.
 * Tracks interface changes. Tracks current time and executes an update every 3
 * seconds. Reads USBSerial data. Triggers handling of incomming USB command when
 * a complete datagram has arrived. Finally checks if 20 seconds has expired
 * without an update and triggers a loss of connection indication. 
 * 
 * Important note: If this loop takes to long to execute the PC COM port will 
 * throw an error as the USB buffer will fill up due to not being read out.
 */
void loop(void)
{
  if (interface != interface_prev)
  {
    /*
     * The interface has changed outside of the loop and needs to be updated.
     */
    interface_prev = interface;
    LCD_ShowBackground(interface);
    screen_refresh = true;
    for (int i = 0; i < MAX_VALUES; i++)
    {
      values[i][V_PREVIOUS] = 1;
      values[i][V_INALARM] = A_OK_NOACK;
    }
  }

  if (millis() - timer_disp_update > 3000)
  {
    /*
     * Updating temps, Updating histogram array, Reading flow, Controlling fan,
     * and sending values to PC only happens every 3 seconds.
     */
    readTemps();
    updateHistory();
    readRpm();
    fanControl();
    sendValues();
    if (interface == 2) drawgraph();
    timer_disp_update = millis();
    checkAlarms();
    checkMode();
    displayUpdate();
    screen_refresh = false; // reset first run indiciation. 
  } 
  else 
  {
    displayUpdate();
  }

  if (SerialUSB.available())
  {
    /* 
     * Read out incoming serial data
     */
    getIncomingChars();
  }

  if (commandComplete == true)
  {
    /* 
     * True if our incoming serial data is terminated correctly.
     * Check to see if the command is correct and process it. 
     * Reset the timer value to the current time to prevent a serial data timeout.
     */
    if (commandCorrect())
      processCommand();
    timer = millis();
    command = "";
    commandComplete = false;
    delay(100);
  }

  if ((millis() - timer) > 30000)
  {
    /* 
     *  Check if our timer is greater than 30seconds, then indicate a loss of comms.  
     */
    values[T_VRM][V_CURRENT] = V_DISCONNECT;
    values[T_CPU][V_CURRENT] = V_DISCONNECT;
    values[P_CPU][V_CURRENT] = V_DISCONNECT;
    values[T_GPU][V_CURRENT] = V_DISCONNECT;
    values[P_GPU][V_CURRENT] = V_DISCONNECT;
    values[T_SYS][V_CURRENT] = V_DISCONNECT;
  }
}

/*
 * ISR attached to D2 for reading the hall effect sensor of rotating equipment.
 * This only counts pulses. Calculation is done in readRpm(). 
 */
void pin11Interrupt(void)
{
  rpm_pulse++;
}

/*
 * This section reads the three primary temperature sensors and updates the value in the main values array.
 * the TempRead() function returns a float and needs to be converted to a deci-degrees value before being stored.
 */
void readTemps(void)
{
  float temp = TempRead(THERM_RAD);
  values[T_RAD][V_CURRENT] = (uint16_t)(temp * 10);
  temp = TempRead(THERM_TOP);
  values[T_CASET][V_CURRENT] = (uint16_t)(temp * 10);
  temp = TempRead(THERM_BOTTOM);
  values[T_CASEB][V_CURRENT] = (uint16_t)(temp * 10);
}

/*
 * Step through the array and check if we are in alarm. If so, set the alarm value.
 * Also resets mode to scan. If any value is in alarm it sets mode to ALARM. If mode
 * stays in scan it will be set correctly in checkmode() 
 */
void checkAlarms(void) 
{
  mode = MODE_SCAN;

  for (int i = 0; i<MAX_VALUES; i++)
  {
    if (values[i][V_TYPE] != V_TYPE_FLOW)
    /* Check for high alarm conditions */ 
    {
      if (values[i][V_CURRENT] >= values[i][V_ALARM]) 
      {
        if (values[i][V_INALARM] != A_ALARM) values[i][V_INALARM] = A_ALARM_NOACK;
        mode = MODE_ALARM;
      } 
      else
      {
        if (values[i][V_INALARM] != A_OK) values[i][V_INALARM] = A_OK_NOACK;
      }
    }
    else 
    /* Check for low alarm conditions */
    {
      if (values[i][V_CURRENT] <= values[i][V_ALARM])
      {
        if (values[i][V_INALARM] != A_ALARM) values[i][V_INALARM] = A_ALARM_NOACK;
        mode = MODE_ALARM;
      } 
      else 
      {
        if (values[i][V_INALARM] != A_OK) values[i][V_INALARM] = A_OK_NOACK;
      }
    }
  }
}

/*
 * Check to see what the current operating mode is but only if mode set to scan. 
 */
void checkMode(void) 
{
  if (mode == MODE_SCAN) 
  {
    if ((values[F_RAD][V_CURRENT] < 30) && (values[F_CASET][V_CURRENT] < 30))
      mode = MODE_SILENT;
    else if ((values[F_RAD][V_CURRENT] >= 30) && (values[F_CASET][V_CURRENT] < 30))
      mode = MODE_NORMAL;
    else if ((values[F_RAD][V_CURRENT] >= 30) && (values[F_CASET][V_CURRENT] >= 30))
      mode = MODE_COOLING;    
  }
}

/*
 * This section steps through the history array and updates the latest temperature value with radiator temperature.
 * as it goes it moves all data up the array. Note the history value stores pixels so a pre-calculation is done 
 * converting 25-45 degrees (250-450decideg) into 0-150 pixels. Values are clamped between 1 and 150. 
 */
void updateHistory(void) 
{
  for (int i=GRAPH_LENGTH-1; i>0; i--) history[i] = history[i-1];
  if (values[T_RAD][V_CURRENT] < 252) history[0] = 1;
  else history[0] = (uint8_t)(((values[T_RAD][V_CURRENT]-250)*15)/20);
  if (history[0] > 150) history[0] = 150;
}

/*
 * This function converts the pulse counter attached to the D2 via interrupts into an RPM figure and stores
 * it in the values array. Flowmeter produces 96 pulses / L. Calculation is stepwise to ensure uint16 isn't
 * overrun. 
 */
void readRpm(void)
{
  uint16_t factor = (millis() - timer_rpm);
  factor = 37500 / factor;
  values[FLOW][V_CURRENT] = rpm_pulse * factor;
  timer_rpm = millis();
  rpm_pulse = 0;
}

/*
 * If the command received was determined to be correct then this will process the command. 
 * Helper functions are used for conversion of incoming values. 
 * The sequence is not revelant since the helper functions read the command variable directly. 
 * As long as all values are sent through in 3 digits then the helper functions can function
 * based on #defines. 
 */
void processCommand(void)
{
  if (command.charAt(P_ID) == 'P')
  {
    if (values[T_VRM][V_CURRENT] == V_DISCONNECT) 
    {
      //If we just connected reset alarm status to ensure no NACKs get set when the value comes in the first time.
      values[T_VRM][V_INALARM] = A_OK_NOACK;
      values[T_CPU][V_INALARM] = A_OK_NOACK;
      values[P_CPU][V_INALARM] = A_OK_NOACK;
      values[T_GPU][V_INALARM] = A_OK_NOACK;
      values[P_GPU][V_INALARM] = A_OK_NOACK;
      values[T_SYS][V_INALARM] = A_OK_NOACK;
    }
    values[T_VRM][V_CURRENT] = parseArguement(P_T_VRM);
    values[T_CPU][V_CURRENT] = parseArguement(P_T_CPU);
    values[P_CPU][V_CURRENT] = parseArguement(P_P_CPU);
    values[T_GPU][V_CURRENT] = parseArguement(P_T_GPU);
    values[P_GPU][V_CURRENT] = parseArguement(P_P_GPU);
    values[T_SYS][V_CURRENT] = parseArguement(P_T_SYS);
  }
  else if (command.charAt(H_ID) == 'H')
  {
    commandsend = "A";
    for (uint8_t i = 0; i < MAX_VALUES; i++)
    {
      commandsend += ":";
      commandsend += values[i][2];
    }
    commandsend += ";";
    SerialUSB.println(commandsend);
  }
  else if (command.charAt(H_ID) == 'F')
  {
    commandsend = "F";
    for (uint8_t i = 0; i < MAX_FANS; i++)
    {
      for (uint8_t j = 0; j < 5; j++)
      {
        commandsend += ":";
        commandsend += fans[i][j];
      }
    }
    commandsend += ":";
    commandsend += interface;
    commandsend += ";";
    SerialUSB.println(commandsend);
  }
  else if (command.charAt(P_ID) == 'B')
  {
    values[T_VRM][V_ALARM] = parseArguement(B_T_VRM);
    values[T_CPU][V_ALARM] = parseArguement(B_T_CPU);
    values[T_GPU][V_ALARM] = parseArguement(B_T_GPU);
    values[T_SYS][V_ALARM] = parseArguement(B_T_SYS);
    values[T_CASEB][V_ALARM] = parseArguement(B_T_CASEB);
    values[T_CASET][V_ALARM] = parseArguement(B_T_CASET);
    values[T_RAD][V_ALARM] = parseArguement(B_T_RAD);
    values[FLOW][V_ALARM] = parseArguement(B_FLOW);
    //Reset preview values after alarms have been updated to ensure the screen is redrawn.
    for (uint8_t i = 0; i < MAX_VALUES; i++)
      values[i][V_PREVIOUS] = 0;
    Settings_Write();
  }
  else if (command.charAt(P_ID) == 'G')
  {

    fans[FAN_RAD][FAN_TEMP_LOW] = parseArguement(G_FAN1_TL);
    fans[FAN_RAD][FAN_OUT_LOW] = parseArguement(G_FAN1_OL);
    fans[FAN_RAD][FAN_TEMP_HIGH] = parseArguement(G_FAN1_TH);
    fans[FAN_RAD][FAN_OUT_HIGH] = parseArguement(G_FAN1_OH);
    fans[FAN_RAD][FAN_HYS] = parseArguement(G_FAN1_HYS);
    fans[FAN_TOP][FAN_TEMP_LOW] = parseArguement(G_FAN2_TL);
    fans[FAN_TOP][FAN_OUT_LOW] = parseArguement(G_FAN2_OL);
    fans[FAN_TOP][FAN_TEMP_HIGH] = parseArguement(G_FAN2_TH);
    fans[FAN_TOP][FAN_OUT_HIGH] = parseArguement(G_FAN2_OH);
    fans[FAN_TOP][FAN_HYS] = parseArguement(G_FAN2_HYS);
    fans[FAN_AON][FAN_TEMP_LOW] = parseArguement(G_FAN3_TL);
    fans[FAN_AON][FAN_OUT_LOW] = parseArguement(G_FAN3_OL);
    fans[FAN_AON][FAN_TEMP_HIGH] = parseArguement(G_FAN3_TH);
    fans[FAN_AON][FAN_OUT_HIGH] = parseArguement(G_FAN3_OH);
    fans[FAN_AON][FAN_HYS] = parseArguement(G_FAN3_HYS);
    interface = parseArguement(G_INTERFACE);
    //Settings the fans temperatures to 0 forces a recalculation.
    fans[FAN_RAD][FAN_PREV_TEMP] = 0;
    fans[FAN_TOP][FAN_PREV_TEMP] = 0;
    fans[FAN_AON][FAN_PREV_TEMP] = 0;
    Settings_Write();
  }
  else if (command.charAt(P_ID) == 'S')
  {
    Settings_Read();
  }
  else if (command.charAt(P_ID) == 'I')
  {
    SerialUSB.println("Interface Cycle...;");
    interface++;
    if (interface > 2) interface = 0;
    Settings_Write();
    mode_previous = 255;
  }
  else if (command.charAt(P_ID) == 'R')
  {
    SerialUSB.println("Enabling WDT for Reset...;");
    watchdogReset();
  }
}




