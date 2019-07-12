#include <Arduino.h>

/*
 * Predeclarations required for Visual Studio Code, not necessary on the
 * Arduino IDE / compilers.
 */

void pin11Interrupt();
void readTemps();
void readRpm();
void updateHistory();
void checkAlarms();
void checkMode();
void processCommand();

