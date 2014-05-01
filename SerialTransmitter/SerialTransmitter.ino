#include <serial.h>

#define buttonPin 2

int buttonState;
int lastButtonState = LOW;

long lastDebounceTime = 0;
long debounceDelay = 50;

void setup() {
  Serial.begin(9600);

  /* We are not using external pullup resistors so we use an onboard
   * pullup resistor to avoid any floating values
   * We could also accomplish this with the following lines of code
   * pinMode(buttonPin, INPUT);
   * digitalWrite(buttonPin, HIGH);
   */
  pinMode(buttonPin, INPUT_PULLUP);
  
}

void loop() {
  /* The following code avoids button bouncing.
   * See: www.arduino.cc/en/Tutorial/Debounce for more details
   */
  int reading = digitalRead(buttonPin);
  
  if (reading != lastButtonState) {
    lastDebounceTime = millis(); 
  }
  
  if ((millis() - lastDebounceTime) > debounceDelay) {
    if (reading != buttonState) {
      buttonState = reading;

      // Only transmit the "toggle" command if the buttonState is LOW
      if (buttonState == LOW) {
        Serial.println("toggle");
      }
    }
  }
  lastButtonState = reading;
}
