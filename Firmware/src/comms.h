#include "Arduino.h"
#include "variables.h"
#include "Debug.h"

/*
 * Define Communication Interface:
 * H: Hello - PC Request connect to device. Respond with Alarms and current Interface. 
 * P: PC - Interval: Sending updated values to device
 * V: Values - Interval: Local values being sent back to PC
 * A: Alarms - PC Request - Local to reply with alarms. 
 * B: Alarms - PC Sends setpoints for new alarms.
 * F: Fans - PC Request - Local to reply with current fan curves.
 * G: Fans - PC Sends setpoints for new fan curves. 
 * I: Interface - PC Request - Local to reply with current set interface.
 * J: Interface - PC Sends setpoints for new interface.
 */

#define P_ID 0
#define P_T_VRM 2
#define P_T_CPU 6
#define P_P_CPU 10
#define P_T_GPU 14
#define P_P_GPU 18
#define P_T_SYS 22
#define P_LENGTH 26 //6 values

#define H_ID 0
#define H_LENGTH 3 //cmd only

#define A_LENGTH 3 //cmd only

#define B_ID 0
#define B_T_VRM 2
#define B_T_CPU 6
#define B_T_GPU 10
#define B_T_SYS 14
#define B_T_CASEB 18
#define B_T_CASET 22
#define B_T_RAD 26
#define B_FLOW 30
#define B_LENGTH 34 //8 values

#define F_LENGTH 3 //cmd only

#define G_ID 0
#define G_FAN1_TL 2
#define G_FAN1_OL 6
#define G_FAN1_TH 10
#define G_FAN1_OH 14
#define G_FAN1_HYS 18
#define G_FAN2_TL 22
#define G_FAN2_OL 26
#define G_FAN2_TH 30
#define G_FAN2_OH 34
#define G_FAN2_HYS 38
#define G_FAN3_TL 42
#define G_FAN3_OL 46
#define G_FAN3_TH 50
#define G_FAN3_OH 54
#define G_FAN3_HYS 58
#define G_INTERFACE 62
#define G_LENGTH 66 //16 values

/*
 * Helper fuction to check if a character is numeric by seeing if the ASCII
 * value is between 48 and 57 (number) 
 */
boolean isNumeric(char character);

/*
 * Helper function to convert 3 sequential numbers into an integer by subtracting
 * the ASCII value 0 from the string and adding it to a preset integer depending 
 * on it's power. e.g. 267 = return 2*100+6*10+7
 */
uint16_t parseArguement(int argOffset);

/*
 * This function tests to see if a command received was valid. The test consists of checking to see
 * if the desired data exchange has the correct command byte, and the correct number of bytes. 
 * Returns:
 *  false = no correct leading ID or length incorrect
 *  true = length matches leading ID, presumed valid correct data
 */
boolean commandCorrect();

/*
 * When called this will send the values to the connected PC. Only the values recorded by 
 * the unit will be sent as the rest come from the PC already and others such as alarms and
 * settings are sent on request only.
 */
void sendValues();


/*
 * Function to read incoming characters and add them to a string.
 * This function also checks for ASCII 10 = LF (Line Feed) and if found sets 
 * commandcomplete = true. On next loop execute the command will be parsed. 
 */
void getIncomingChars();