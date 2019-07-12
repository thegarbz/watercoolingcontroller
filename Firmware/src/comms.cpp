#include "comms.h"

/*
 * Helper fuction to check if a character is numeric by seeing if the ASCII
 * value is between 48 and 57 (number) 
 */
boolean isNumeric(char character)
{
  boolean ret = false;
  if (character >= 48 && character <= 57)
  {
    ret = true;
  }
  return ret;
}

/*
 * Helper function to convert 3 sequential numbers into an integer by subtracting
 * the ASCII value 0 from the string and adding it to a preset integer depending 
 * on it's power. e.g. 267 = return 2*100+6*10+7
 */
uint16_t parseArguement(int argOffset)
{
  uint16_t ret = 0;
  if (isNumeric(command.charAt(argOffset)))
  {
    ret = (command.charAt(argOffset) - 48) * 100;
    if (isNumeric(command.charAt(argOffset + 1)))
    {
      ret += (command.charAt(argOffset + 1) - 48) * 10;
      if (isNumeric(command.charAt(argOffset + 2)))
      {
        ret += command.charAt(argOffset + 2) - 48;
      }
      else
        DEBUG("Not a number, 1x\n");
    }
    else
      DEBUG("Not a number, 10x\n");
  }
  else
    DEBUG("Not a number, 100x\n");
  return ret;
}

/*
 * This function tests to see if a command received was valid. The test consists of checking to see
 * if the desired data exchange has the correct command byte, and the correct number of bytes. 
 * Returns:
 *  false = no correct leading ID or length incorrect
 *  true = length matches leading ID, presumed valid correct data
 */
boolean commandCorrect(void)
{
  boolean ret = false;
  if (command.charAt(P_ID) == 'P' && command.length() == P_LENGTH)
  { //PC sending values
    ret = true;
    DEBUG("Command P Valid\n");
  }
  else if (command.charAt(P_ID) == 'H' && command.length() == H_LENGTH)
  { //PC Greeting
    ret = true;
    DEBUG("Command H Valid\n");
  }
  else if (command.charAt(P_ID) == 'A' && command.length() == A_LENGTH)
  { //PC requested Alarms
    ret = true;
    DEBUG("Command A Valid\n");
  }
  else if (command.charAt(P_ID) == 'B' && command.length() == B_LENGTH)
  { //PC updating Alarms
    ret = true;
    DEBUG("Command B Valid\n");
  }
  else if (command.charAt(P_ID) == 'F' && command.length() == F_LENGTH)
  { //PC reqeuested Fan curves
    ret = true;
    DEBUG("Command F Valid\n");
  }
  else if (command.charAt(P_ID) == 'G' && command.length() == G_LENGTH)
  { //PC updated Fan curves
    ret = true;
    DEBUG("Command G Valid\n");
  }
  else if (command.charAt(P_ID) == 'I' && command.length() == H_LENGTH)
  { //PC requested Interface Update
    ret = true;
    DEBUG("Command I Valid\n");
  }
  else if (command.charAt(P_ID) == 'S' && command.length() == H_LENGTH)
  { //PC requested Settings-reread
    ret = true;
    DEBUG("Command S Valid\n");
  }
  else if (command.charAt(P_ID) == 'R' && command.length() == H_LENGTH)
  { //PC requested Settings-reread
    ret = true;
    DEBUG("Command R Valid\n");
  }
  else
  {
    //Received an invalid command, reply with the command a a command invalid symbol.
    DEBUG(command);
    DEBUG("Command INVALID\n");
    command = "";
    commandComplete = false;
  }
  return ret;
}

/*
 * When called this will send the values to the connected PC. Only the values recorded by 
 * the unit will be sent as the rest come from the PC already and others such as alarms and
 * settings are sent on request only.
 */
void sendValues(void)
{
  commandsend = "V";
  for (uint8_t i = T_CASEB; i <= FLOW; i++)
  {
    commandsend += ":";
    commandsend += values[i][0];
  }
  commandsend += ";";
  SerialUSB.println(commandsend);
}

/*
 * Function to read incoming characters and add them to a string.
 * This function also checks for ASCII 10 = LF (Line Feed) and if found sets 
 * commandcomplete = true. On next loop execute the command will be parsed. 
 */
void getIncomingChars(void)
{
  char inChar = SerialUSB.read();
  if (inChar == 10)
  {
    commandComplete = true;
    DEBUG("CMD Received\n");
  }
  else
  {
    command += inChar;
  }
}