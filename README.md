# Red Alert Button
An Arduino powered "Red Alert" Button for the game [Artemis Spaceship Bridge Simulator](http://www.artemis.eochu.com/)

## Hardware
* Arduino Nano
* Emergency Stop Button (or other button)
* 22 gauge wire to connect the Arduino to the Emergency Stop Button
* 1 Gang 18 cu. in. Outlet Box (to hold the button and the Arduino)

## Features
* A push of the Emergency Stop Button triggers the Arduino to write to the serial port (SerialTransmitter)
* A lightweight command line application runs on Windows to listen to the serial port and apply the keyboard shortcut for the Red Alert (SerialReceiver)

## Requirements/Dependencies
* Windows (to run Artemis and the SerialReceiver)

## Usage
* Wire the button to the Arduino as shown
![Circuit Diagram](/Circuit/Diagram.png?raw=true)
* Upload the Arduino Code (make note of the COM port used)
* Assemble the Outlet Box
* Download the [latest release](https://github.com/rohankapoorcom/Red-Alert-Button/releases/download/v1.0/SerialReceiver.zip) of SerialReceiver and run it with the following arguments
	SerialReceiver.exe COMX 9600
* Start Artemis and pick the Communications role

## License

Copyright (c) 2014 [Rohan Kapoor](http://rohankapoor.com)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.