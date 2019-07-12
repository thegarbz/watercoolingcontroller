/******************************************************************************
**************************Hardware interface layer*****************************
* | file          :   DEV_Config.h
* | version     :   V1.0
* | date        :   2017-12-11
* | function    :
    Provide the hardware underlying interface
******************************************************************************/
#ifndef _DEV_CONFIG_H_
#define _DEV_CONFIG_H_

#include <SPI.h>
#include <Wire.h>
#include "debug.h"
#include <SD.h>
#include "variables.h"

//LCD Configuration
#define LCD_CS 10
#define LCD_CS_0		digitalWrite(LCD_CS, LOW)
#define LCD_CS_1		digitalWrite(LCD_CS, HIGH)
#define LCD_RST 8
#define LCD_RST_0		digitalWrite(LCD_RST, LOW)
#define LCD_RST_1		digitalWrite(LCD_RST, HIGH)
#define LCD_DC 7
#define LCD_DC_0		digitalWrite(LCD_DC, LOW)
#define LCD_DC_1		digitalWrite(LCD_DC, HIGH)
#define LCD_BL 9

//Touch configuration *NOT USED*
#define TP_CS 4
#define TP_CS_0     digitalWrite(TP_CS, LOW)
#define TP_CS_1     digitalWrite(TP_CS, HIGH)

//SD configuration
#define SD_CS 5
#define SD_CS_0     digitalWrite(LCD_CS, LOW)
#define SD_CS_1     digitalWrite(LCD_CS, HIGH)

#define SPI4W_Write_Byte(__DATA) SPI.transfer(__DATA)

//GPIO config 
#define FAN_RAD 0
#define FAN_TOP 1
#define FAN_AON 2

#define THERM_RAD 1
#define THERM_TOP 2
#define THERM_BOTTOM 3
#define AI_THERM_RAD A0
#define AI_THERM_TOP A1
#define AI_THERM_BOTTOM A2

#define ADC_SAMPLES 8

#define T_SETUP 99

//SD card
#define SETTINGS_LENGTH 42


/********************************************************************************
function:
      Defines Interface locations and elements
********************************************************************************/
// ---- Font Selection ----
#define GUI_FONT_L        &Font48
#define GUI_FONT          &Font32 
#define GUI_FONT_S        &Font24 

// ---- Font Alert Colour ----
#define FONT_ALERT      RED

// ---- Base Interface Offsets ----
#define I_NC_OFFSET_X   -3
#define I_NC_OFFSET_Y   31

#define T_OFFSET_X      32

// ---- Histogram information ----
#define I2_GRAPH_X          62
#define I2_GRAPH_Y         234
#define I2_GRAPH_W         357
#define I2_GRAPH_H         148
#define I2_GRAPH_XE        419
#define GRAPH_COLOR_B   0x4BB1
#define GRAPH_COLOR_L   0x8E7F




void Settings_Read();
void Settings_Write();
uint8_t System_Init(void);
void PWM_SetValue(uint16_t value);
void Driver_Delay_ms(unsigned long xms);
void Driver_Delay_us(int xus);
void SPI4W_Write_Byte_F(char data);
void watchdogReset(void);
float TempRead(uint8_t temp);

#endif
