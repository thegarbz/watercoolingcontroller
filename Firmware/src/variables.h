#include "Arduino.h"
#include "DEV_Config.h"
#include "LCD_GUI.h"

//Array Lenghts
#define MAX_VALUES 13       //Number of measurements
#define MAX_FANS 3          //Number of fans
#define GRAPH_LENGTH 358    //Number of points on histogram
#define MAX_LENGTH 70       //Number of bytes in Serial Comms

//Fan Array Items
#define FAN_TEMP_LOW 0
#define FAN_OUT_LOW 1
#define FAN_TEMP_HIGH 2
#define FAN_OUT_HIGH 3
#define FAN_HYS 4
#define FAN_CUR_TEMP 5
#define FAN_PREV_TEMP 6
#define FAN_CUR_OUT 7
#define FAN_DIR 8

//Fan Direction for hysteresis
#define FAN_DIR_DOWN 0
#define FAN_DIR_UP 1

//Values Array Items
#define V_CURRENT 0
#define V_PREVIOUS 1
#define V_ALARM 2
#define V_TYPE 3
#define V_INALARM 4
#define V_DISCONNECT 999

//Values Array V_TYPE 
#define V_TYPE_DEG 1
#define V_TYPE_DECIDEG 2
#define V_TYPE_PERC 3
#define V_TYPE_FLOW 4

//Values Array V_INALARM
#define A_OK 1
#define A_OK_NOACK 2
#define A_ALARM 3
#define A_ALARM_NOACK 4

//Operating Modes
#define MODE_SILENT   0
#define MODE_NORMAL   1
#define MODE_COOLING  2
#define MODE_ALARM    3
#define MODE_SCAN     4
#define MODE_NONSENSE 5

//Value_support Array Items
#define VS_X 0
#define VS_Y 1
#define VS_FONT 2
#define VS_XSTART 3
#define VS_YSTART 4
#define VS_XEND 5
#define VS_YEND 6

//Values_support VS_X DO not Draw
#define DO_NOT_DRAW 500

//Array identifiers for Values and Values_support
#define T_VRM 0
#define T_CPU 1
#define P_CPU 2
#define T_GPU 3
#define P_GPU 4
#define T_SYS 5
#define T_CASEB 6
#define T_CASET 7
#define F_CASET 8
#define T_RAD 9
#define F_RAD 10
#define F_AON 11
#define FLOW 12

extern uint8_t mode, mode_previous;
extern bool screen_refresh;
extern uint16_t values[MAX_VALUES][5];
extern uint16_t values_support[MAX_VALUES][3][7];
extern uint16_t mode_support[3][7];
extern uint8_t fans[MAX_FANS][9];
extern uint8_t history[GRAPH_LENGTH];
extern uint8_t interface, interface_prev;
extern String command;
extern String commandsend;
extern boolean commandComplete;
extern uint8_t fanbias;



