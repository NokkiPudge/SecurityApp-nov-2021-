


#define ledPinG 8
#define ledPinR 9
#define ledPinB 10
int soundPin=3;
boolean trigger=false;
void setup() {
 Serial.begin(9600);

pinMode(ledPinG, OUTPUT);
pinMode(ledPinR, OUTPUT);
pinMode(ledPinB, OUTPUT);
pinMode(soundPin, OUTPUT);
digitalWrite(ledPinB, HIGH);
delay(2500);
digitalWrite(ledPinB,LOW);
  

}


void loop() {
 
  if(analogRead(A0) > 500){ 
   
    trigger=true;
    Serial.println("AHTUNG!!! ROBBER HAS BEEN DETECTED");
    digitalWrite(ledPinG, HIGH);
    digitalWrite(ledPinR, LOW);
    analogWrite(soundPin,50);
    delay(500);
    analogWrite(soundPin,0);
    delay(500);
   
  }else{

trigger=false;
Serial.println("robber didnt detected");
digitalWrite(ledPinR, HIGH);
digitalWrite(ledPinG, LOW);
    
  }
 


}
