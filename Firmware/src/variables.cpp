#include "variables.h"

/*
 * Defines current operating mode (Silent, Normal, Cooling, Alarm, Scan)
 */
uint8_t mode = MODE_NONSENSE;
uint8_t mode_previous = MODE_NORMAL;

/*
 * True if all values need to be redrawn
 */
bool screen_refresh = true;

/*
 * Bias for fans when system is in alarm
 */
uint8_t fanbias = 30;

/* 
 *values[measurement][5]
 * Current Value. V_DISCONNECT = pc connection lost
 * Previous Value.
 * Alarm Value. 998 = alarm disabled
 * Unit Value. 1 = degC, 2 = deci-degC, 3=%, 4=flow
 * Alarm Condition. 1 = noalarm, 2 = noalarm(unack), 3 = alarm, 4 = alarm(unack)
 */
uint16_t values[MAX_VALUES][5] = {
    {0, 0, 998, V_TYPE_DEG, A_OK_NOACK},    //VRM Temp
    {0, 0, 998, V_TYPE_DEG, A_OK_NOACK},    //CPU Temp
    {0, 0, 998, V_TYPE_PERC, A_OK_NOACK},  //CPU Utilisation %
    {0, 0, 998, V_TYPE_DEG, A_OK_NOACK},    //GPU Temp
    {0, 0, 998, V_TYPE_PERC, A_OK_NOACK},  //GPU Utilisation %
    {0, 0, 998, V_TYPE_DEG, A_OK_NOACK},    //Sys Temp
    {0, 0, 450, V_TYPE_DECIDEG, A_OK_NOACK}, //Case Bottom Temp (Local Thermistor 3) Deci-degrees
    {0, 0, 450, V_TYPE_DECIDEG, A_OK_NOACK}, //Case Top Temp (Local Thermistor 2) Deci-degrees
    {0, 5, 998, V_TYPE_PERC, A_OK_NOACK},    //Case Top Fan (Local Fan Output 2) 0-100% PWM
    {0, 0, 450, V_TYPE_DECIDEG, A_OK_NOACK}, //Rad Temp (Local Thermistor 1) Deci-degrees
    {0, 5, 998, V_TYPE_PERC, A_OK_NOACK},    //Rad Fan (Local Fan Output 1) 0-100% PWMM
    {0, 5, 998, V_TYPE_PERC, A_OK_NOACK},    //Always On Fan (Local Fan Output 3) 0-100% PWMM
    {0, 0, 100, V_TYPE_FLOW, A_OK_NOACK}     //Flow (Local Fan 3 used as input PWM)
};

/* 
 * values_support[measurement][interface][7]
 * X-Text. 500 = do not draw
 * Y-Text.
 * Font Color.
 * X-Box-Start.
 * Y-Box-Start.
 * X-Box-End.
 * Y-Box-End.
 */
uint16_t values_support[MAX_VALUES][3][7] = {
    // {Xoffset, Yoffset, fontcolor} and once for each Interface (currently 3). X-Offset of 500 means do not draw.
    {{15, 23, LGREY, 2, 15, 93, 61},            {DO_NOT_DRAW, 0, 0, 0, 0, 0, 0},            {DO_NOT_DRAW, 0, 0, 0, 0, 0, 0}},           //VRM Temp
    {{15, 105, WHITE, 2, 97, 93, 143},          {395, 22, LGREY, 375, 15, 478, 59},         {DO_NOT_DRAW, 0, 0, 0, 0, 0, 0}},           //CPU Temp
    {{DO_NOT_DRAW, 0, 0, 0, 0, 0, 0},           {DO_NOT_DRAW, 0, 0, 0, 0, 0, 0},            {DO_NOT_DRAW, 0, 0, 0, 0, 0, 0}},           //CPU Utilisation %
    {{15, 188, WHITE, 2, 180, 93, 226},         {395, 73, LGREY, 375, 66, 478, 110},        {DO_NOT_DRAW, 0, 0, 0, 0, 0, 0}},           //GPU Temp
    {{DO_NOT_DRAW, 0, 0, 0, 0, 0, 0},           {DO_NOT_DRAW, 0, 0, 0, 0, 0, 0},            {DO_NOT_DRAW, 0, 0, 0, 0, 0, 0}},           //GPU Utilisation %
    {{DO_NOT_DRAW, 0, 0, 0, 0, 0, 0},           {DO_NOT_DRAW, 0, 0, 0, 0, 0, 0},            {DO_NOT_DRAW, 0, 0, 0, 0, 0, 0}},           //Sys Temp
    {{15, 272, LGREY, 2, 264, 93, 310},         {DO_NOT_DRAW, 0, 0, 0, 0, 0, 0},            {DO_NOT_DRAW, 0, 0, 0, 0, 0, 0}},           //Case Bottom Temp
    {{401, 12, LGREY, 388, 4, 479, 50},         {382, 125, LGREY, 375, 117, 478, 161},      {DO_NOT_DRAW, 0, 0, 0, 0, 0, 0}},           //Case Top Temp
    {{401, 58, LGREY, 388, 50, 479, 96},        {354, 269, LGREY, 335, 262, 438, 304},      {DO_NOT_DRAW, 0, 0, 0, 0, 0, 0}},           //Case Top Fan
    {{401, 135, WHITE, 388, 127, 479, 173},     {105, 26, WHITE, 89, 17, 284, 80},          {99, 9, WHITE, 75, 1, 220, 45}},            //Rad Temp
    {{401, 181, LGREY, 388, 173, 479, 219},     {242, 269, LGREY, 223, 262, 326, 304},      {DO_NOT_DRAW, 0, 0, 0, 0, 0, 0}},           //Rad Fan
    {{DO_NOT_DRAW, 0, 0, 0, 0, 0, 0},           {130, 269, LGREY, 111, 262, 214, 304},      {DO_NOT_DRAW, 0, 0, 0, 0, 0, 0}},           //AON Fan
    {{399, 260, LGREY, 388, 252, 479, 298},     {105, 105, WHITE, 89, 95, 284, 158},       {273, 9, WHITE, 259, 1, 404, 45}}             //Flow
};

/* 
 * mode_support[interface][7]
 * X-Text. 500 = do not draw
 * Y-Text.
 * Font Color.
 * X-Box-Start.
 * Y-Box-Start.
 * X-Box-End.
 * Y-Box-End.
 */
uint16_t mode_support[3][7] = {
    {500, 0, WHITE, 0, 0, 0, 0},                //Not used in Interface 0
    {211, 220, WHITE, 111, 212, 438, 256},      //Interface 1
    {176, 283, WHITE, 77, 275, 404, 319}        //Interface 2
};

/*
 * fans[fan_no][9]
 * Temperature Low
 * Output % Low
 * Temperature High
 * Output % High
 * Hysteresis
 * Current Temp
 * Previous Temp
 * Previous Direction
 */
uint8_t fans[MAX_FANS][9] = {
    //TempLow, Out%Low, TempHigh, Out%High, Hysteresis, curTemp, prevTemp, prevDirection
    {33, 20, 45, 100, 2, 0, 0, 0, FAN_DIR_DOWN}, //Fan1
    {34, 20, 45, 100, 2, 0, 0, 0, FAN_DIR_DOWN}, //Fan2
    {60, 30, 65, 40, 2, 0, 0, 0, FAN_DIR_DOWN}   //Fan3
};

uint8_t history[GRAPH_LENGTH] = {0};

uint8_t interface, interface_prev = 1;

String command = String(MAX_LENGTH);
String commandsend = String(MAX_LENGTH);
boolean commandComplete = false;

