#include <Servo.h>

Servo clawServos[2];  // create servo object to control a servo

int pos = 0; 
String inputString = "";
boolean stringComplete = false;

void setup() {
	Serial.begin(9600);
	inputString.reserve(200);
	clawServos[0].attach(9);  // attaches the servo on pin 9 to the servo object
	clawServos[1].attach(10);   
}

void loop() {
	if (stringComplete) {
	Serial.println(inputString);
	inputString = " ";
	stringComplete = false;
	}
}

void serialEvent() {
	while(Serial.available()) {
	char inChar = (char)Serial.read();
	inputString += inChar;
	
	if (inChar == '\n') {
		stringComplete = true;
	}
	
	if (inChar == 'p'){
		pinch();
		}
	}
}

void pinch() {
	for (pos = 0; pos <= 180; pos += 1) { // goes from 0 degrees to 180 degrees
	// in steps of 1 degree
	for (int i = 0; i <= sizeof(clawServos); i += 1) {
			clawServos[i].write(pos);  // tell servo to go to position in variable 'pos'
	}
      
	delay(15);                       // waits 15ms for the servo to reach the position
	}
	for (pos = 180; pos >= 0; pos -= 1) { // goes from 180 degrees to 0 degrees
	for (int i = 0; i <= sizeof(clawServos); i += 1) {
		clawServos[i].write(pos);  // tell servo to go to position in variable 'pos'
	}
	delay(15);                       // waits 15ms for the servo to reach the position
	}
}

