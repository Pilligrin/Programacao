void setup() {
  // put your setup code here, to run once:
pinMode(2, OUTPUT);
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
digitalWrite(2, LOW);
int led  = 0;
delay(500);
Serial.println(led);
digitalWrite(2, HIGH);
delay(500);
led  = 1;
Serial.println(led);
}
