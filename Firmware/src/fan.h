#include "Arduino.h"

uint16_t fanCalc(int fan);
void fanControl();
void FanPWM_Set(uint8_t fan_sel, uint16_t value); 
void FanPWM_Init(void); 