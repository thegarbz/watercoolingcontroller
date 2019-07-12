/*****************************************************************************
* | File      	:	Debug.h
* | Author      :   Waveshare team
* | Function    :	debug with prntf
* | Info        :
*----------------
* |	This version:   V1.0 - Garbz Edit
* | Date        :   2019-05-22
* | Info        :   Basic version Edited to output to SerialUSB
*
******************************************************************************/
#ifndef __DEBUG_H
#define __DEBUG_H
#include <Wire.h>

#define DEV_DEBUG 0

#if DEV_DEBUG
	#define DEBUG(__info) SerialUSB.print(__info)
#else
	#define DEBUG(__info)  
#endif

#endif
