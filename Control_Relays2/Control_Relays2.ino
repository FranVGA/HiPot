/*Reset*/
int reset = 2;
/*Test*/
int test = 3;
/*Pass*/
int Pass = 4;
/*Fail*/
int Fail = 5;
 
void setup() {
  /*Reset*/
  pinMode(reset,OUTPUT);
  /*Test*/
  pinMode(test,OUTPUT);
  /*Pass*/
  pinMode(Pass,INPUT);
  /*Fail*/
  pinMode(Fail,INPUT);

 
  // Y se inicializan en alto (rele desactivado)
  digitalWrite(reset,HIGH);
  digitalWrite(test,HIGH);
  Serial.begin(9600);
}
 
void loop() {
while(Serial.available() == 0);
char val = Serial.read();
controlEncendido(val);
}

void controlRely(char val) {
  if (val == 'B')
  {
    digitalWrite(test,LOW);
  }
}
void controlEncendido(char val) {
  bool passsw;
  bool failsw;   
  if (val == 'A')
  {
      Serial.flush();    
      digitalWrite(test,HIGH);
      passsw = digitalRead(Pass);   
      failsw = digitalRead(Fail);
      if (passsw == true)
      {
        Serial.println("Pasa");
      }   
      else if (failsw == true)
      {
        Serial.println("Falla");
      }
      else{Serial.println("");}
  }
}
