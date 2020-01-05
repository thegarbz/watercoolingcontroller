Graphics
==================================

These graphics files are used by the firmware and must be loaded onto the SD card. 

Use
-------------------
- "back#.jpg" are the backgrounds of the three main screens. The graphic is statically loaded on start or when changing the interface. 
- "i-XXXX.jpg" are icons which may be used in the code. In many cases these icons are unused and form part of the static background.
- "w-XXXX.jpg" are warning icons for the disconnection alarm. The high temperature alarm was never implemented. 

Modifying
-------------------
Graphics may be modified providing dimensions remain the same. The graphics are standard 24bit bitmaps. In theory the code can load icon graphics of any dimension. In practice the way the Waveshare driver is implemented the horizontal resolution must not change otherwise it is incorrectly written out to the display. 

