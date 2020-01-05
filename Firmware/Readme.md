Firmware
==========================

Overview
--------

The firmware was built around the LCD driver by Waveshare and modified slightly to improve performance. Every function in the firmware is commented and documented. This page will give a general overview of what each file does and and the communications protocol between the controller and the PC. 

File Explaination
-----------------

The files listed below are responsible for the following (Note both the header and the code are listed under one heading):

#### Comms.h ####
* Configuration for the communication protocol including which values have which position in the serial packet and the expected length of each packet.
* Helper functions to check if a string is numeric and convert a numeric string to a value.
* Testing functions to see if commands received have the correct length and valid starting character. 
* Sending values (recorded data from the fan controller) to the PC.

#### Debug.h ####
* Contains a flag to enable debug functions in the code which are transmitted over the USB serial port. 

#### DEV_config.h ####
* Configuration for hardware pins. If you need to change the default pin assignment, then change them here.
* Configuration for graphing parameters and system fonts. 
* System initialisation and helper functions for I2C communication.
* Reading and writing settings (alarms and fan curves) to the SD Card
* Reading, averaging of thermistors, and conversion into deci-degrees Celcius.
* Manual software watchdog reset.

#### Draw_display.h ####
* Responsible for drawing and updating the values on each display. This function handles all display changes except for the initial loading of the background image from the SD card. The routine is called and will read out which interface is currently selecte and update code accordingly. It also updates the display for values currently in alarm, and if the interface 2 is selected it will draw a histoy graph. 

#### Fan_control_2.h ####
* Core file for the project containing main program loop. 
* Initialisation of the microcontroller.
* Interrupt handler for flow meter input and calculation for flow rate. 
* Handling of the history array.
* Handling of received commands from the PC. 

#### fan.h ####
* Initialisation of the PWM units and multiplexers for the ATSAMD21. 
* Calculation of all fan control loops.
* Biasing fans +30% if we are in alarm condition. 

#### LCD_BMP.h ####
File originally from Waveshare
* Outputing BMP files to the display from the SD card. Note the filenames are described in the LCD_BMP.cpp file.

#### LCD_Driver.h ####
File originally from Waveshare
* Initialising the LCD controller.
* Functions for drawing to the LCD. 

#### LCD_GUI.h ####
File originally from Waveshare
* Functions for drawing shapes and handling strings.
* Modified to handle deci-degree values.  

#### variables.h ####
* Defines array identifiers and operating modes.
* Contains the values (recorded values and alarms) and values_support (display locations and colours), mode, fans (settings for 2 point control), and history arrays. 

More information about how each function works can be read in the comments in the source code.

Communications protocol
-----------------------

All communication to and from the controller uses the same format:
"{Command Character}:{Value1}:{Value2}:{ValueX};\r\n"

Every command starts with a capital letter indicating what command this is, and ends with a semicolon followed by CRLF. On both ends when the semicolon is received the command character is checked and the number of received bits (on the controller side) or the number of received colon separated values (computer side) is checked against hard coded constants. This ensures that before taking action the correct length of data is received and we're not taking action on a byte that may be the result of a communications error. 

The commands used are as follows:
 * H: Hello - Zero Length - PC connected to controller. Controller responds with settings for alarms and the current interface. 
 * P: PC - 6 Values - PC is transmitting PC monitored data such as CPU temperature and utilisation to the controller.  
 * V: Values - XXX Values - Controller sends local values such as water temperature and fan speed to the PC.
 * A: Alarms - Zero Length - Same as Hello. 
 * B: Alarms - 8 Values - PC sends updated alarm setpoints to controller. Controller stores these on the SD card. 
 * F: Fans - Zero Length - PC requests fan settings from controller. - Controller replies with current fan curves.
 * G: Fans - 16 Values - PC Sends updated fan curve setpoints to controller. Controller stores these on the SD card. 
 * I: Interface Zero Length - PC requests controller to change interface. Controller stores updated interface on the SD card so that last used interface is reused on power-on. 
 * R: Reset - Zero Length - PC requests the controller to reset. Controller enables watchdog timer and after 2 seconds will reset. 

Any changes to data sent or transmitted will require updating the check for number of bytes / values on both sides of the link. 
Also note that some lengths are fixed by the size of the array holding values. e.g. the SendValues(void) procedure will step through the values array from i=0 to T_CASEB (6) and transmit this number of values to the PC. Modification of the array or changing the location of T_CASEB within the array without updating the communications check will result in a comms failure. 













