/*****************************************************************************
* | File          :   LCD_Bmp.c
* | Author      :   Waveshare team
* | Function    :   Show SDcard BMP picto LCD 
* | Info        :
*----------------
* | This version:   V1.0 - Garbz Edit
* | Date        :   2019-05-22
* | Info        :   Basic version - Modified for additional diagnostics. 
******************************************************************************/
#include <SD.h>
#include <SPI.h>

#include "LCD_Bmp.h"
#include "Debug.h"

BMP_DIS BMP_Dis;
extern LCD_DIS sLCD_DIS;

char BMP_Icons[7][FILENAME_LEN] = //Note changing this requires the typedef IMAGE_FILE to be updated in LCD_Bmp.h
{
  "w-conn.bmp",
  "w-temp.bmp",
  "i-cpu.bmp",
  "i-fan.bmp",
  "i-gpu.bmp",
  "i-pc.bmp",
  "i-water.bmp"
};

char BMP_Background[3][FILENAME_LEN] =
{
  "back.bmp",
  "back2.bmp",
  "back3.bmp"
};

File bmpFile;
File icoFile;

/*********************************************/
// These read data from the SD card file and convert them to big endian
// (the data is stored in little endian format!)
static uint16_t Read16(File f)
{
  uint16_t d;
  uint8_t b;
  b = f.read();
  d = f.read();
  d <<= 8;
  d |= b;
  return d;
}

// LITTLE ENDIAN!
static uint32_t Read32(File f)
{
  uint32_t d;
  uint16_t b;

  b = Read16(f);
  d = Read16(f);
  d <<= 16;
  d |= b;
  return d;
}

static boolean ReadBmpHeader(File f)
{
  uint16_t BMP_File;
  BMP_File = Read16(f) ;//0000h 2byte: file type
  
  if (BMP_File != 0x4D42) {
    // magic bytes missing
    DEBUG("Magic Byte Missing\n");
    return false;
  }

  // read file size
  BMP_Dis.Size = Read32(f);//0002h 4byte: file size

  // read and ignore creator bytes
  Read32(f);//0006h 4byte:

  BMP_Dis.Index = Read32(f);//000ah 4byte: Offset between file head and image (offbits)

  // read DIB header
  BMP_Dis.Header_Size = Read32(f);//000Eh 4byte: Bitmap header = 40

  BMP_Dis.BMP_Width = Read32(f);//12-15:Image wide
  DEBUG("Width = ");
  DEBUG(BMP_Dis.BMP_Width);
  DEBUG("\n");
  BMP_Dis.BMP_Height = Read32(f);//16-19:Image high
  DEBUG("Height = ");
  DEBUG(BMP_Dis.BMP_Height);
  DEBUG("\n");
  
  if (BMP_Dis.BMP_Width != sLCD_DIS.LCD_Dis_Column || BMP_Dis.BMP_Height != sLCD_DIS.LCD_Dis_Page)  {   // if image is not 480*320, return false
    DEBUG("BMP is not 480*320\n");
    //return false;
  }

  if (Read16(f) != 1) {//1A-1B :0 for the use of the palette, 1 for the number of color indices
    DEBUG("Palette not supported\n");
    return false;
  }
  
  BMP_Dis.Bit_Pixel = Read16(f);//1C-1D：Whether the image is compressed

  if (Read32(f) != 0) {//1E-21：
    DEBUG("Compression not supported\n");
    // compression not supported!
    return false;
  }

  return true;
}

#define BUFFPIXEL_X3(__val)    ( (__val) * 3)                 // BUFFPIXELx3
#define RGB24TORGB16(R,G,B) (( (R) >> 3 ) << 11 ) | (( (G) >> 2 ) << 5) | ( (B) >> 3)
static void LCD_DrawBmp( int x, int y)
{
  bmpFile.seek( BMP_Dis.Index);
  #if DEV_DEBUG
  uint32_t time = millis();
  #endif
  
  uint16_t BuffPixel =  BMP_Dis.BMP_Width;
  uint16_t X_Point = (uint16_t)x;
  uint16_t Y_Point = (uint16_t)y;

  uint8_t ReadBuff[BUFFPIXEL_X3(BuffPixel)];
  //clear buffer
  for (uint16_t N = 0; N < BUFFPIXEL_X3(BuffPixel); N++) {
    ReadBuff[N] = 0;
  }
  DEBUG("Drawing at: ");
  DEBUG(X_Point);
  DEBUG(", ");
  DEBUG(Y_Point);
  DEBUG("\n");
  for ( Y_Point = (uint16_t)y; Y_Point < (BMP_Dis.BMP_Height + (uint16_t)y); Y_Point++) {//Total display column
    //for ( X_Point = (uint16_t)x; X_Point < ((BMP_Dis.BMP_Width / BuffPixel) + (uint16_t)x); X_Point++) {//Show a line in the line
      bmpFile.read(ReadBuff, BUFFPIXEL_X3(BuffPixel));

      //show bmp to LCD
      int k = 0;
      LCD_SetWindow( X_Point, Y_Point, (X_Point + BuffPixel) , Y_Point);

      
      LCD_DC_1;
      LCD_CS_0;
      for (uint16_t j = 0; j < BuffPixel; j++) {
        k = j * 3;
        SPI4W_Write_Byte( (RGB24TORGB16(ReadBuff[k + 2], ReadBuff[k + 1], ReadBuff[k])) >> 8);
        SPI4W_Write_Byte( (RGB24TORGB16(ReadBuff[k + 2], ReadBuff[k + 1], ReadBuff[k]))  & 0XFF);
      }
      LCD_CS_1;
    //}
  }
  DEBUG("Show BMP use ");
  DEBUG(millis() - time);
  DEBUG(" ms.\n");
}

/**************************************************************************
    This procedure reads a bitmap and draws it to the screen
    its sped up by reading many pixels worth of data at a
    time instead of just one pixel at a time. increading the buffer takes
    more RAM but makes the drawing a little faster. 20 pixels' worth
    is probably a good place
**************************************************************************/
void SD_Init(void) 
{
  SD_CS_1;
  LCD_CS_1;
  TP_CS_1;

  Sd2Card card;
  card.init(SPI_FULL_SPEED, SD_CS);
  if (!SD.begin( SD_CS ))  {
    DEBUG("SD init failed!\n");
    while (1);                              // init fail, die here
  }
  DEBUG("SD init OK!\n");
}

void LCD_ShowBackground(uint8_t backnum) 
{
  /*
   * Draw the backgroun. Note that the background can be referenced directly by number.
   */
  DEBUG("\n\nAttempting Back File\n"); 
  bmpFile = SD.open(BMP_Background[backnum]);
  if (! bmpFile) {
    DEBUG(BMP_Background[backnum]);
    DEBUG(" image not found\n");
    return;
  } else {
    DEBUG(BMP_Background[backnum]);
    DEBUG(" image open\n");
  }

  if (! ReadBmpHeader(bmpFile)) {
    DEBUG("Header problem\n");
    return;
  }

  LCD_SetGramScanWay(D2U_R2L);
  LCD_DrawBmp(0, 0);
  bmpFile.close();
  LCD_SetGramScanWay(SCAN_DIR_DFT);

}

void LCD_ShowICO( int x, int _y, IMAGE_FILE file) {
  int y = 320 - _y;
  bmpFile = SD.open(BMP_Icons[file]);
  DEBUG("\n\nAttempting ICO File\n"); 
  if (! bmpFile) {
    DEBUG(BMP_Icons[file]);
    DEBUG(" image not found\n");

  } else {
    DEBUG(BMP_Icons[file]);
    DEBUG(" image open\n");
  }
  
  if (! ReadBmpHeader(bmpFile)) {
    DEBUG("ReadHeaderReturn 0");

  }

  LCD_SetGramScanWay(D2U_R2L);
  LCD_DrawBmp(x, y);
  bmpFile.close();
  LCD_SetGramScanWay(SCAN_DIR_DFT);
  
}
