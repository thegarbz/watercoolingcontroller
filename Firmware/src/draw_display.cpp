#include "draw_display.h"
#include "variables.h"
#include "LCD_Bmp.h"

char degC[4] = {127, 'C', '\0'}; // degreeC symbol. (font32.c)
char lpm[2] = {'~', '\0'};       // lpm symbol.  (font32.c)

/* 
   * Display update is called to draw the screen. The screen is drawn with whatever is
   * currently in memory and dependent on the currently selected interface. Any processing 
   * of numbers is done elsewhere. Communication is done elsewhere. 
   * 
   * The only facility to pass data in and out are via the values array with pre-determined
   * values, or the support array with pre-determined supports. Additionally the Interface
   * variable is read to determine which display to draw. 
   */
void displayUpdate(void)
{
    /*
     * Generic Display Updater
     */
  for (int i = 0; i < MAX_VALUES; i++)
  {
    //Check to see if we need to draw the value
    if ((values_support[i][interface][VS_X] != DO_NOT_DRAW) && (values[i][V_CURRENT] != values[i][V_PREVIOUS])) 
    {
      //Checking which font we need
      sFONT *pGUI_FONT = &Font32;
      if (((i == FLOW) || (i == T_RAD)) && (interface == 1)) pGUI_FONT = &Font48;
      //Check if we need to draw disconnected case:  
      if (values[i][V_CURRENT] == V_DISCONNECT)
      {
        LCD_SetArealColor(values_support[i][interface][VS_XSTART], values_support[i][interface][VS_YSTART], values_support[i][interface][VS_XEND], values_support[i][interface][VS_YEND], FONT_BACKGROUND);
        LCD_ShowICO(values_support[i][interface][VS_X] + I_NC_OFFSET_X, values_support[i][interface][VS_Y] + I_NC_OFFSET_Y, IMAGE_NOTCONNECTED);
      }
      else
      {
        COLOR FONT_COLOR_BACK = FONT_BACKGROUND;
        COLOR FONT_COLOR_FORE = values_support[i][interface][VS_FONT];
        // Switch alarm values. Normal alarm values just need an update. Noack values need have their boxes redrawn. 
        switch (values[i][V_INALARM])
        {
          case A_ALARM_NOACK:
            LCD_SetArealColor(values_support[i][interface][VS_XSTART], values_support[i][interface][VS_YSTART], values_support[i][interface][VS_XEND], values_support[i][interface][VS_YEND], FONT_ALERT);
            LCD_ShowUnits(i, FONT_ALERT, WHITE); 
            values[i][V_INALARM] = A_ALARM;
            values[i][V_PREVIOUS] = 0; //This will force a complete redraw including unchanged numbers. 
            //continue with ALARM
          case A_ALARM:
            FONT_COLOR_BACK = FONT_ALERT;
            FONT_COLOR_FORE = FONT_FOREGROUND;
            break;
          case A_OK_NOACK:
            LCD_SetArealColor(values_support[i][interface][VS_XSTART], values_support[i][interface][VS_YSTART], values_support[i][interface][VS_XEND], values_support[i][interface][VS_YEND], FONT_BACKGROUND);
            LCD_ShowUnits(i, FONT_BACKGROUND, values_support[i][interface][VS_FONT]); 
            values[i][V_INALARM] = A_OK;
            values[i][V_PREVIOUS] = 0; //This will force a complete redraw including unchanged numbers. 
            //contiue with OK
          case A_OK:
            //Nothing to do 
            break;
        }
        if (interface == 0) //Interface 0 has different display requirements. 
        {
          if (values[i][V_TYPE] == V_TYPE_DECIDEG)    GUI_DisNum(values_support[i][interface][VS_X], values_support[i][interface][VS_Y], values[i][V_CURRENT] / 10, GUI_FONT, FONT_COLOR_BACK, FONT_COLOR_FORE);
          else if (values[i][V_TYPE] == V_TYPE_FLOW)  GUI_DisNum_Deci_Fast(values_support[i][interface][VS_X], values_support[i][interface][VS_Y], values[i][V_CURRENT] / 6, values[i][V_PREVIOUS] / 6, GUI_FONT, FONT_COLOR_BACK, FONT_COLOR_FORE);
          else                                        GUI_DisNum(values_support[i][interface][VS_X], values_support[i][interface][VS_Y], values[i][V_CURRENT], GUI_FONT, FONT_COLOR_BACK, FONT_COLOR_FORE); 
        } 
        else 
        {
          if (values[i][V_TYPE] == V_TYPE_DECIDEG)    GUI_DisNum_Deci_Fast(values_support[i][interface][VS_X], values_support[i][interface][VS_Y], values[i][V_CURRENT], values[i][V_PREVIOUS], pGUI_FONT, FONT_COLOR_BACK, FONT_COLOR_FORE);
          else                                        GUI_DisNum(values_support[i][interface][VS_X], values_support[i][interface][VS_Y], values[i][V_CURRENT], pGUI_FONT, FONT_COLOR_BACK, FONT_COLOR_FORE); 
        }
      }
    }
  values[i][V_PREVIOUS] = values[i][V_CURRENT];
  }
  //If the mode has changed, update the mode
  if ((mode != mode_previous) && (interface != 0))
  {
    if (mode_previous == MODE_ALARM) LCD_SetArealColor(mode_support[interface][VS_XSTART], mode_support[interface][VS_YSTART], mode_support[interface][VS_XEND], mode_support[interface][VS_YEND], FONT_BACKGROUND);
    switch (mode)
    {
    case MODE_SILENT:
      GUI_DisString_EN(mode_support[interface][VS_X], mode_support[interface][VS_Y], " Silent ", GUI_FONT, FONT_BACKGROUND, WHITE);
      break;
    case MODE_NORMAL:
      GUI_DisString_EN(mode_support[interface][VS_X], mode_support[interface][VS_Y], " Normal ", GUI_FONT, FONT_BACKGROUND, WHITE);
      break;
    case MODE_COOLING:
      GUI_DisString_EN(mode_support[interface][VS_X] + 8, mode_support[interface][VS_Y], "Cooling", GUI_FONT, FONT_BACKGROUND, WHITE);
      break;
    case MODE_ALARM:
      LCD_SetArealColor(mode_support[interface][VS_XSTART], mode_support[interface][VS_YSTART], mode_support[interface][VS_XEND], mode_support[interface][VS_YEND], FONT_ALERT);
      GUI_DisString_EN(mode_support[interface][VS_X] + 8, mode_support[interface][VS_Y], " ALARM ", GUI_FONT, FONT_ALERT, WHITE);
      break;
    }
    mode_previous = mode;
  }
}

/*
 * This helper to the displayupdate() function draws unit symbols at with the chosen foreground and background
 * font colour at the appropriate area. It reads directly from the constants in LCD_GUI.h. 
 * As this function is passed an integer identifying the value of interest to update, we need to test for which
 * interface we are currently updating as there's no way to identify e.g. T_VRM for interface 1 vs 2 since in 
 * other functions they step through by integers 1-MAX_VALUES. It's just as easy to check the current interface
 * here as it is to pass it through to the function every time so we may as well just do it. 
 */
void LCD_ShowUnits(int i, uint16_t font_b, uint16_t font_f)
{
  if (interface == 0)
  {
    switch (values[i][V_TYPE])
    {
    case V_TYPE_DEG:
      //GUI_DisString_EN( I0-T_VRM_X+I0-T_OFFSET_X, I0-T_VRM_Y, degC, GUI_FONT, font_b, font_f);
      GUI_DisString_EN(values_support[i][interface][VS_X] + T_OFFSET_X, values_support[i][interface][VS_Y], degC, GUI_FONT, font_b, font_f);
      break;
    case V_TYPE_DECIDEG:
      //GUI_DisString_EN( I0-T_CPU_X+I0-T_OFFSET_X, I0-T_CPU_Y, degC, GUI_FONT, font_b, font_f);
      GUI_DisString_EN(values_support[i][interface][VS_X] + T_OFFSET_X, values_support[i][interface][VS_Y], degC, GUI_FONT, font_b, font_f);
      break;
    case V_TYPE_PERC:
      GUI_DisString_EN(values_support[i][interface][VS_X] + T_OFFSET_X, values_support[i][interface][VS_Y], " %", GUI_FONT, font_b, font_f);
      break;
    case V_TYPE_FLOW:
      GUI_DisString_EN(values_support[i][interface][VS_X] + T_OFFSET_X + 19, values_support[i][interface][VS_Y], lpm, GUI_FONT, font_b, font_f);
      break;
    }
  }
  else if (interface == 1)
  {
    //Compensate for the font
    sFONT *pGUI_FONT = &Font32;
    int add_offset = 0;
    if ((i == FLOW) || (i == T_RAD))
    {
      pGUI_FONT = &Font48;
      if (i == FLOW)
        add_offset = 58;
      else
        add_offset = 82;
    }
    else
    {
      if (i == T_CASET)
        add_offset = 30;
    }
    //Compensate for unit length

    switch (values[i][V_TYPE])
    {
    case V_TYPE_DEG:
      //GUI_DisString_EN( I0-T_VRM_X+I0-T_OFFSET_X, I0-T_VRM_Y, degC, GUI_FONT, font_b, font_f);
      GUI_DisString_EN(values_support[i][interface][VS_X] + T_OFFSET_X + add_offset, values_support[i][interface][VS_Y], degC, pGUI_FONT, font_b, font_f);
      break;
    case V_TYPE_DECIDEG:
      //GUI_DisString_EN( I0-T_CPU_X+I0-T_OFFSET_X, I0-T_CPU_Y, degC, GUI_FONT, font_b, font_f);
      GUI_DisString_EN(values_support[i][interface][VS_X] + T_OFFSET_X + add_offset, values_support[i][interface][VS_Y], degC, pGUI_FONT, font_b, font_f);
      break;
    case V_TYPE_PERC:
      GUI_DisString_EN(values_support[i][interface][VS_X] + T_OFFSET_X + add_offset, values_support[i][interface][VS_Y], " %", pGUI_FONT, font_b, font_f);
      break;
    case V_TYPE_FLOW:
      GUI_DisString_EN(values_support[i][interface][VS_X] + T_OFFSET_X + add_offset, values_support[i][interface][VS_Y], "L/h", pGUI_FONT, font_b, font_f);
      break;
    }
  }
  else if (interface == 2)
  {
    //Compensate for the font
    sFONT *pGUI_FONT = &Font32;
    int add_offset = 35;

    //Compensate for unit length

    switch (values[i][V_TYPE])
    {
    case V_TYPE_DEG:
      //GUI_DisString_EN( I0-T_VRM_X+I0-T_OFFSET_X, I0-T_VRM_Y, degC, GUI_FONT, font_b, font_f);
      GUI_DisString_EN(values_support[i][interface][VS_X] + T_OFFSET_X + add_offset, values_support[i][interface][VS_Y], degC, pGUI_FONT, font_b, font_f);
      break;
    case V_TYPE_DECIDEG:
      //GUI_DisString_EN( I0-T_CPU_X+I0-T_OFFSET_X, I0-T_CPU_Y, degC, GUI_FONT, font_b, font_f);
      GUI_DisString_EN(values_support[i][interface][VS_X] + T_OFFSET_X + add_offset, values_support[i][interface][VS_Y], degC, pGUI_FONT, font_b, font_f);
      break;
    case V_TYPE_PERC:
      GUI_DisString_EN(values_support[i][interface][VS_X] + T_OFFSET_X + add_offset, values_support[i][interface][VS_Y], " %", pGUI_FONT, font_b, font_f);
      break;
    case V_TYPE_FLOW:
      GUI_DisString_EN(values_support[i][interface][VS_X] + T_OFFSET_X + add_offset, values_support[i][interface][VS_Y], "L/h", pGUI_FONT, font_b, font_f);
      break;
    }
  }
}

/*
 * This section draws the temperature graph on the screen by calculating vertical lines. It
 * is called by the displayUpdate() routine if and only if the interface = 2 so no additional
 * check for interfaces is performed. 
 */
void drawgraph(void)
{
  int i=0;
  int k=0;
  if (!screen_refresh) 
  {
    for (i=0; i<GRAPH_LENGTH-1; i++) 
    {
      k = i+1;
      //Clear above/below value
      if (history[i] > history[k]) 
        LCD_SetArealColor(I2_GRAPH_XE-i-1, I2_GRAPH_Y-history[i], I2_GRAPH_XE-i, I2_GRAPH_Y-history[k]+1, GRAPH_COLOR_B);  
      else if (history[i] < history[k])
        LCD_SetArealColor(I2_GRAPH_XE-i-1, I2_GRAPH_Y-history[k]-2, I2_GRAPH_XE-i, I2_GRAPH_Y-history[i], BLACK);   
      //Draw new value
      LCD_SetArealColor(I2_GRAPH_XE-i-1, I2_GRAPH_Y-history[i], I2_GRAPH_XE-i, I2_GRAPH_Y-history[i]+1, GRAPH_COLOR_L); 
    }
    //Left most value can't rely on the previous value for the calculation so redraw it completely.
    i++;
    LCD_SetArealColor(I2_GRAPH_XE-i, I2_GRAPH_Y-history[GRAPH_LENGTH-1], I2_GRAPH_XE-i+1, I2_GRAPH_Y, GRAPH_COLOR_B); 
    LCD_SetArealColor(I2_GRAPH_XE-i, I2_GRAPH_Y-I2_GRAPH_H, I2_GRAPH_XE-i+1, I2_GRAPH_Y-history[GRAPH_LENGTH-1], BLACK); 
    LCD_SetArealColor(I2_GRAPH_XE-i, I2_GRAPH_Y-history[GRAPH_LENGTH-1], I2_GRAPH_XE-i+1, I2_GRAPH_Y-history[GRAPH_LENGTH-1]+1, GRAPH_COLOR_L);
  }
  else
  {
    //We got here from a screen change. Need to update everything. 
    for (i=0; i<GRAPH_LENGTH; i++) 
    {
      LCD_SetArealColor(I2_GRAPH_XE-i-1, I2_GRAPH_Y-history[i], I2_GRAPH_XE-i, I2_GRAPH_Y, GRAPH_COLOR_B);  
      LCD_SetArealColor(I2_GRAPH_XE-i-1, I2_GRAPH_Y-history[i], I2_GRAPH_XE-i, I2_GRAPH_Y-history[i]+1, GRAPH_COLOR_L); 
    }
  }
}