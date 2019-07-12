#include "variables.h"
#include "fan.h"
#include "Arduino.h"
#include "debug.h"
#include "DEV_Config.h"

uint16_t fancontrol = 0;
boolean bias_enabled = false;

/* 
 * This helper script does the primary calculation for a given fan based on the current values in its array.
 * Execution of this is not atomic. 
 * It also checks to see if we are above or below minimum level.
 * It should only be called AFTER hysteresis checks are complete. 
 */
uint16_t fanCalc(int fan)
{
  uint16_t ret = 0;
  if (fans[fan][FAN_CUR_TEMP] <= fans[fan][FAN_TEMP_LOW])
  {
    ret = fans[fan][FAN_OUT_LOW];
    DEBUG("Fan Low");
  }
  else if ((fans[fan][FAN_CUR_TEMP] > fans[fan][FAN_TEMP_LOW]) && (fans[fan][FAN_CUR_TEMP] < fans[fan][FAN_TEMP_HIGH]))
  {
    ret = (((fans[fan][FAN_OUT_HIGH] - fans[fan][FAN_OUT_LOW]) * (fans[fan][FAN_CUR_TEMP] - fans[fan][FAN_TEMP_LOW])) / (fans[fan][FAN_TEMP_HIGH] - fans[fan][FAN_TEMP_LOW])) + fans[fan][FAN_OUT_LOW];
    DEBUG(ret);
  }
  else
  {
    ret = fans[fan][FAN_OUT_HIGH];
    DEBUG("Fan High");
  }
  DEBUG("\n");
  if (ret < 30)
    return 0;
  else
    return ret;
}

/* 
 * This function is the control loop for the fans. It is responsible for all fans, determining the control slope
 * controlling hysteresis. It copies data in to a temporary array and copies it out again. Hysteresis is 
 * controlled by monitoring if the the previous controlled move was in the up or down direction. 
 */
void fanControl(void)
{
  fans[FAN_RAD][FAN_CUR_TEMP] = values[T_RAD][V_CURRENT] / 10;
  fans[FAN_TOP][FAN_CUR_TEMP] = values[T_RAD][V_CURRENT] / 10;
  fans[FAN_AON][FAN_CUR_TEMP] = values[T_RAD][V_CURRENT] / 10;

  //If we just cleared the alarm state we need to execute the calc below, so set temps to something nonsensical. 
  if ((mode != MODE_ALARM) && (bias_enabled == true)) 
  {
    fans[FAN_RAD][FAN_PREV_TEMP] = 0;
    fans[FAN_TOP][FAN_PREV_TEMP] = 0;
    fans[FAN_AON][FAN_PREV_TEMP] = 0;
    fans[FAN_RAD][FAN_DIR] = FAN_DIR_UP;
    fans[FAN_TOP][FAN_DIR] = FAN_DIR_UP;
    fans[FAN_AON][FAN_DIR] = FAN_DIR_UP;
    bias_enabled = false;
  }

  for (int i = 0; i < MAX_FANS; i++)
  {
    if (fans[i][FAN_DIR] == FAN_DIR_DOWN)
    {
      //Direction Down
      if (fans[i][FAN_CUR_TEMP] < fans[i][FAN_PREV_TEMP])
      {
        //New Low
        fans[i][FAN_PREV_TEMP] = fans[i][FAN_CUR_TEMP];
        fancontrol = fanCalc(i);
        fans[i][FAN_CUR_OUT] = fancontrol;
        FanPWM_Set(i, fancontrol);
      }
      else if (fans[i][FAN_CUR_TEMP] > fans[i][FAN_PREV_TEMP] + fans[i][FAN_HYS])
      {
        //High above Hysteresis
        fans[i][FAN_PREV_TEMP] = fans[i][FAN_CUR_TEMP];
        fans[i][FAN_DIR] = FAN_DIR_UP;
        fancontrol = fanCalc(i);
        fans[i][FAN_CUR_OUT] = fancontrol;
        FanPWM_Set(i, fancontrol);
      }
    }
    else
    {
      //Direction Up
      if (fans[i][FAN_CUR_TEMP] > fans[i][FAN_PREV_TEMP])
      {
        //New High
        fans[i][FAN_PREV_TEMP] = fans[i][FAN_CUR_TEMP];
        fancontrol = fanCalc(i);
        fans[i][FAN_CUR_OUT] = fancontrol;
        FanPWM_Set(i, fancontrol);
      }
      else if (fans[i][FAN_CUR_TEMP] < fans[i][FAN_PREV_TEMP] - fans[i][FAN_HYS])
      {
        //Low below Hysteresis
        fans[i][FAN_PREV_TEMP] = fans[i][FAN_CUR_TEMP];
        fans[i][FAN_DIR] = FAN_DIR_DOWN;
        fancontrol = fanCalc(i);
        fans[i][FAN_CUR_OUT] = fancontrol;
        FanPWM_Set(i, fancontrol);
      }
    }
    //Fan bias in case of Alarm:
    if (mode == MODE_ALARM) 
    {
      fancontrol = fanCalc(i) + fanbias;
      fans[i][FAN_CUR_OUT] = fancontrol;
      FanPWM_Set(i, fancontrol);
      bias_enabled = true;
    }
  }
  values[F_RAD][V_CURRENT] = fans[FAN_RAD][FAN_CUR_OUT];
  values[F_CASET][V_CURRENT] = fans[FAN_TOP][FAN_CUR_OUT];
  values[F_AON][V_CURRENT] = fans[FAN_AON][FAN_CUR_OUT];
  if (values[F_RAD][V_CURRENT] == 100) values[F_RAD][V_CURRENT] = 99;
  if (values[F_CASET][V_CURRENT] == 100) values[F_CASET][V_CURRENT] = 99;
  if (values[F_AON][V_CURRENT] == 100) values[F_AON][V_CURRENT] = 99;
}

/* 
 * Fan PWMs are created using the Timer Counter and Capture/Compare to generate
 * a dual slope PWM signal. Clocks and PER (TOP) value are selected to ensure the
 * frequency is ~25KHz. The clocks are then muxed to pins D[0..2]
 */
void FanPWM_Init(void) 
{
  REG_GCLK_GENDIV = GCLK_GENDIV_DIV(1) |          // Divide the 8MHz clock source by divisor 1: 8MHz/1=8MHz
                    GCLK_GENDIV_ID(4);            // Select Generic Clock (GCLK) 4
  while (GCLK->STATUS.bit.SYNCBUSY);              // Wait for synchronization

  REG_GCLK_GENCTRL = GCLK_GENCTRL_IDC |           // Set the duty cycle to 50/50 HIGH/LOW
                     GCLK_GENCTRL_GENEN |         // Enable GCLK4
                     GCLK_GENCTRL_SRC_OSC8M |     // Set the 8MHz OSC clock source
                     GCLK_GENCTRL_ID(4);          // Select GCLK4
  while (GCLK->STATUS.bit.SYNCBUSY);              // Wait for synchronization

  // Enable the port multiplexer for the digital pin D[0..2]
  PORT->Group[g_APinDescription[0].ulPort].PINCFG[g_APinDescription[0].ulPin].bit.PMUXEN = 1;
  PORT->Group[g_APinDescription[1].ulPort].PINCFG[g_APinDescription[1].ulPin].bit.PMUXEN = 1;
  PORT->Group[g_APinDescription[2].ulPort].PINCFG[g_APinDescription[2].ulPin].bit.PMUXEN = 1;
  
  // Connect the TCC0 timer to digital output D[0..2] - port pins are paired odd PMUO and even PMUXE
  // F specifies the timer: TCC0 on D[0..2] PMUX[0] controls D0 (even) and D1 (odd), PMUX[1] controls D2 (even)
  PORT->Group[g_APinDescription[0].ulPort].PMUX[g_APinDescription[0].ulPin >> 1].reg = PORT_PMUX_PMUXO_F | PORT_PMUX_PMUXE_F;
  PORT->Group[g_APinDescription[2].ulPort].PMUX[g_APinDescription[2].ulPin >> 1].reg = PORT_PMUX_PMUXE_F;

  // Feed GCLK4 to TCC0 and TCC1
  REG_GCLK_CLKCTRL = GCLK_CLKCTRL_CLKEN |         // Enable GCLK4 to TCC0 and TCC1
                     GCLK_CLKCTRL_GEN_GCLK4 |     // Select GCLK4
                     GCLK_CLKCTRL_ID_TCC0_TCC1;        // Feed GCLK4 to TCC0 and TCC1
  while (GCLK->STATUS.bit.SYNCBUSY);              // Wait for synchronization

  // Dual slope PWM operation: timers countinuously count up to PER register value then down 0
  REG_TCC0_WAVE |=  TCC_WAVE_POL(0xF) |           // Reverse the output polarity on all TCC0 outputs
                    TCC_WAVE_WAVEGEN_DSBOTH;     // Setup dual slope PWM on TCC0
  while (TCC0->SYNCBUSY.bit.WAVE);               // Wait for synchronization

  // Each timer counts up to a maximum or TOP value set by the PER register,
  // this determines the frequency of the PWM operation: 
  REG_TCC0_PER = 500;                             // Set the frequency of the PWM on TCC0 to 23kHz
  while (TCC0->SYNCBUSY.bit.PER);                // Wait for synchronization
     
  // Divide the 8MHz signal by 2 giving 4MHz TCC0 timer tick and enable the outputs
  REG_TCC0_CTRLA |= TCC_CTRLA_PRESCALER_DIV2 |   // Divide GCLK4 by 2
                    TCC_CTRLA_ENABLE;            // Enable the TCC0 output
  while (TCC0->SYNCBUSY.bit.ENABLE);             // Wait for synchronization
}

/*
 * This function sets the output of the selected fan value's PWM generator by adjusting the
 * Compare/Capture value which triggers the output change. Input value is assumed to be
 * 0-100%. This must be converted to 0-TOP or 0-500 by multiplying by 5, hence declared as 
 * uint16_t
 */
void FanPWM_Set(uint8_t fan_sel, uint16_t value) 
{
  value *=5;
  switch (fan_sel) {
    case FAN_RAD:
       REG_TCC0_CC3 = value;         // TCC0 CC3 - on WO3 D0
       while (TCC0->SYNCBUSY.bit.CC3); 
       break;
    case FAN_TOP:
       REG_TCC0_CC2 = value;         // TCC0 CC2 - on WO2 D1
       while (TCC0->SYNCBUSY.bit.CC2); 
       break;
    case FAN_AON:
       DEBUG("Fan AON Set");
       REG_TCC0_CC0 = value;         // TCC0 CC0 - on WO4 D2
       while (TCC0->SYNCBUSY.bit.CC0); 
       break;
    default:
      return;
      break;
  }
}