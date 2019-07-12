/*****************************************************************************
* | File          :   LCD_Bmp.h
* | Author      :   Waveshare team
* | Function    :   Show SDcard BMP picto LCD 
* | Info        :
*----------------
* | This version:   V1.0 - Garbz Edit
* | Date        :   2019-05-22
* | Info        :   Basic version - Modified with enum for image. 
******************************************************************************/
#ifndef __LCD_BMP_H__
#define __LCD_BMP_H__

#include "DEV_Config.h"
#include "LCD_Driver.h"
#include "LCD_GUI.h"

#define MAX_BMP         10                      // bmp file num
#define FILENAME_LEN    20                      // max file name length
#define BMP_NUM        	1

/********************************************************************************
function:
      File selector - File name needs to be added to LCD_Bmp.cpp
********************************************************************************/
typedef enum {
    IMAGE_NOTCONNECTED,   
    IMAGE_TEMPWARNING,
    IMAGE_CPU,
    IMAGE_FAN,
    IMAGE_GPU,
    IMAGE_PC,
    IMAGE_WATER
} IMAGE_FILE;

typedef struct {
  uint32_t Size;
  uint32_t Index ;
  uint32_t Header_Size ;
  uint32_t Bit_Pixel ;
  POINT BMP_Width;
  POINT BMP_Height;
} BMP_DIS;

void SD_Init(void);
void LCD_ShowBackground(uint8_t backnum);
void LCD_ShowICO( int x, int y, IMAGE_FILE );

#endif
