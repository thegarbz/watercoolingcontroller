/******************************************************************************
**************************Hardware interface layer*****************************
* | file          :   DEV_Config.
* | version     :   V1.0
* | date        :   2017-12-11
* | function    :
    Provide the hardware underlying interface
******************************************************************************/
#include "DEV_Config.h"

char Settings_File[13] = "settings.bin";

/********************************************************************************
  function:    System Init and exit
  note:
    Initialize the communication method
********************************************************************************/
uint8_t System_Init(void)
{
  //set pin
  pinMode(LCD_CS, OUTPUT);
  pinMode(LCD_RST, OUTPUT);
  pinMode(LCD_DC, OUTPUT);
  pinMode(LCD_BL, OUTPUT);  

  //These were not set correctly for a modern Arduino.
  /*SerialUSB.begin(9600);
  SPI.begin();
  SPI.setDataMode(SPI_MODE0);
  //SPI.setBitOrder(MSBFIRST);
  SPI.setClockDivider(3);
  */
  SPI.beginTransaction(SPISettings(24000000,MSBFIRST,SPI_MODE0));


  return 0;
}

void PWM_SetValue(uint16_t value)
{        
    analogWrite(LCD_BL, value);
}

/********************************************************************************
  function:    Delay function
  note:
    Driver_Delay_ms(xms) : Delay x ms
    Driver_Delay_us(xus) : Delay x us
********************************************************************************/
void Driver_Delay_ms(unsigned long xms)
{
  delay(xms);
}

void Driver_Delay_us(int xus)
{
  for (int j = xus; j > 0; j--);
}

void SPI4W_Write_Byte_F(char data) {
  //There is a 1-byte buffer in front of the
  //the SPI transmit shift register. If that
  //register is empty, we can write.
  //Speedup: write directly to the register
  while(0==(REG_SERCOM4_SPI_INTFLAG&0x1));  //DRE
  REG_SERCOM4_SPI_DATA=data;
}

float TempRead(uint8_t temp)
{
  /* 
   * TempRead is responsible for reading the analogue values of of the specified
   * Analogue Input. The values are read multiple times, averaged and converted
   * to a temperature using the Steinhart-Hart equation. 
   */
  uint8_t i;
  float result = 0;

  switch (temp) {
    case THERM_RAD:
      for (i=0; i<ADC_SAMPLES; i++) {
        result += analogRead(AI_THERM_RAD);
        delay(5);
      }
      break;
    case THERM_TOP:
      for (i=0; i<ADC_SAMPLES; i++) {
        result += analogRead(AI_THERM_TOP);
        delay(5);
      }
      break;
    case THERM_BOTTOM:
      for (i=0; i<ADC_SAMPLES; i++) {
        result += analogRead(AI_THERM_BOTTOM);
        delay(5);
      }
      break;
    default:
      return 0;
      break;
  }
  
  result /= ADC_SAMPLES;           //Average ADC
  //Steinhart-Hart conversion
  result = 1023 / result - 1;     //Convert to resistance
  result = 10000 / result;
  result = result / 10000;        //(R/Ro)
  result = log(result);           //Ln(R/Ro)
  result /= 3950;                 //Ln(R/Ro)/B
  result += 1.0 / (25.0 + 273.15); //Ln(R/Ro)/B + (To + Ko)
  result = 1.0 / result;          //1/(Ln(R/Ro)/B + (To + Ko))
  result -= 273.15;               //1/(Ln(R/Ro)/B + (To + Ko)) - Ko

  return result;
}

void watchdogReset(void) 
{
  /*
   * This enables the watchdog in reset mode and then locks up the CPU
   * effectively forcing the entire uC to reset.
   */
  //Set clock 2 divisor 32.
  GCLK->GENDIV.reg =  GCLK_GENDIV_ID(2) | 
                      GCLK_GENDIV_DIV(4);
  //Enable clock 2 sourced from the 32KHz oscillator for a 1024Hz clock.
  GCLK->GENCTRL.reg = GCLK_GENCTRL_ID(2) |
                      GCLK_GENCTRL_GENEN |
                      GCLK_GENCTRL_SRC_OSCULP32K |
                      GCLK_GENCTRL_DIVSEL;
  while(GCLK->STATUS.bit.SYNCBUSY);
  //Set WDT to source clock 2
  GCLK->CLKCTRL.reg = GCLK_CLKCTRL_ID_WDT |
                      GCLK_CLKCTRL_CLKEN |
                      GCLK_CLKCTRL_GEN_GCLK2;
  //Disable WDT for configuration
  WDT->CTRL.reg = 0;
  while(WDT->STATUS.bit.SYNCBUSY);
  //Disable early warning, set 4096 cycles (4 seconds), disable window mode. 
  WDT->INTENCLR.bit.EW   = 1;      
  WDT->CONFIG.bit.PER    = 0x9;   
  WDT->CTRL.bit.WEN      = 0; 
  while(WDT->STATUS.bit.SYNCBUSY);
  //Clear current WDT counter. 
  WDT->CLEAR.reg = WDT_CLEAR_CLEAR_KEY;
  while(WDT->STATUS.bit.SYNCBUSY);
  //Enable the WDT.
  WDT->CTRL.bit.ENABLE = 1;            
  while(WDT->STATUS.bit.SYNCBUSY);
  //The software never resets outside of here so expect a reset in 4 seconds. 
}

/*
 * This function is executed once at startup. It reads the settings file from the SD Card 
 * and updates the alarms and fan curve arrays appropriately. Data is stored direcltyin 
 * HEX format sequentially for the entire array as during saving the array is simply stepped
 * through and dumped to the file. It can be read back the same way. 
 */
void Settings_Read(void)
{
  File setFile = SD.open(Settings_File);
  if (setFile)
  {
    DEBUG("Settings file found!\n");
    if (setFile.available() == SETTINGS_LENGTH)
    {
      //Step through all the fans and read the single uint8_t byte and store in array.
      for (uint8_t i = 0; i < MAX_FANS; i++)
      {
        for (uint8_t j = 0; j < 5; j++)
        {
          fans[i][j] = setFile.read();
        }
      }
      //Step through all values and read 2 uint8_t bytes (big endian) format in array.
      for (uint8_t i = 0; i < MAX_VALUES; i++)
      {
        char a = setFile.read();
        char b = setFile.read();
        values[i][V_ALARM] = (a << 8) | b;
      }
      DEBUG("Interface before: ");
      DEBUG(interface);
      interface = setFile.read();
      DEBUG("Interface after: ");
      DEBUG(interface);
    }
    else
    {
      DEBUG("Incorrect Length:");
      DEBUG(setFile.available());
      DEBUG("\n");
    }
  }
  else
    DEBUG("Settings file not available\n");
  setFile.close();
}

/*
 * This function is executed every time new settings are written. It stores the current 
 * settings arrays on a file on the SD card direclty in HEX format sequentially for 
 * the entire array. It can be read back the same way. 
 */
void Settings_Write(void)
{
  if (SD.exists(Settings_File))
    SD.remove(Settings_File);
  File setFile = SD.open(Settings_File, FILE_WRITE);
  if (setFile)
  {
    DEBUG("Settings file found for write!\n");
    //Move to start of file since WRITE defaults to append.
    //Step through all the fans and read the single uint8_t byte and store in array.
    for (uint8_t i = 0; i < MAX_FANS; i++)
    {
      for (uint8_t j = 0; j < 5; j++)
      {
        setFile.write(fans[i][j]);
      }
    }
    //Step through all values and read 2 uint8_t bytes (big endian) format in array.
    for (uint8_t i = 0; i < MAX_VALUES; i++)
    {
      char a = values[i][V_ALARM] >> 8;
      char b = values[i][V_ALARM];
      setFile.write(a);
      setFile.write(b);
    }
    setFile.write(interface);
  }
  else
    DEBUG("Settings file not available\n");
  setFile.close();
}