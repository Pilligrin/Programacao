#include <WiFi.h>
#include <PubSubClient.h>
#include <ESPmDNS.h>
#include <Adafruit_MPU6050.h>
#include <Adafruit_Sensor.h>
#include <Wire.h>
Adafruit_MPU6050 mpu;

//OBS: Sensor: VCC => GPIO 17, GND => GND, SCL => GPIO 22, SDA => GPIO 21
//PLACA: ESP32 DEV MODULE

//Net Setup
#define NET_SSID "ID_DO_WIFI" //Nome do Wi-Fi
#define NET_PASSWORD "senha" //Senha do Wi-fi

//Variáveis para o MQTT e Wi-Fi
#define MQTT_ID "pelegrino-esp32-vibracao"
#define MQTT_BROKER "test.mosquitto.org" //No aplicativo de cliente MQTT Colocar no host: mqtt://test.mosquitto.org:1883
#define MQTT_PORT 1883 //porta do MQTT
#define MQTT_TOPIC "teste123"
char dados[80] = "";//Nome da string de dados a serem publicados
WiFiClient espClient; //Cliente de rede
PubSubClient MQTT(espClient); //Cliente MQTT


void setupWifi() {
  //Configura a conexão à rede sem fio

  if (WiFi.status() == WL_CONNECTED)
        return;
  
  //Serial.println();
  //Serial.print("Connecting to ");
  //Serial.println(NET_SSID);
  
  WiFi.begin(NET_SSID, NET_PASSWORD);
  
  while (WiFi.status() != WL_CONNECTED) {
      delay(500);
      //Serial.print(".");
  }
  
  //Serial.println("");
  //Serial.println("WiFi connected");
  //Serial.println("IP address: ");
  //Serial.println(WiFi.localIP());
}

void setupMQTT() {
   MQTT.setServer(MQTT_BROKER, MQTT_PORT);   //informa qual broker e porta deve ser conectado
   //MQTT.setCallback(mqtt_callback);            //atribui função de callback (função chamada quando qualquer informação de um dos tópicos subescritos chega)
   while (!MQTT.connected()) 
    {
        //Serial.print("*Tentando se conectar ao Broker MQTT: ");
        //Serial.println(MQTT_BROKER);
        if (MQTT.connect(MQTT_ID)) 
        {
            Serial.println("Conectado com sucesso ao broker MQTT!");
        } 
        else
        {
            Serial.println("Falha ao reconectar no broker.");
            Serial.println("Havera nova tentativa de conexao em 2s");
            delay(2000);
        }
    }
}

void setup(void) {

  //VCC criado no GPIO 17, por inacessibilidade
  pinMode(17, OUTPUT);
  digitalWrite(17, HIGH);

  //Serial
  Serial.begin(115200); // iniciar o monitor serial 

 //Verifica se o módulo GY-521 (MPU6050) está conectado 
  if (!mpu.begin()) {
    Serial.println("Falha ao conectar o módulo");// caso não encontre
    while (1) {
      delay(10);
    }
  }
  Serial.println("Módulo conectado"); // caso encontre
// Definição da variação do chip.
  mpu.setAccelerometerRange(MPU6050_RANGE_8_G);
  Serial.print("Variação do aceleremetro para: ");
  switch (mpu.getAccelerometerRange()) {
  case MPU6050_RANGE_2_G:
    Serial.println("+-2G");
    break;
  case MPU6050_RANGE_4_G:
    Serial.println("+-4G");
    break;
  case MPU6050_RANGE_8_G:
    Serial.println("+-8G");
    break;
  case MPU6050_RANGE_16_G:
    Serial.println("+-16G");
    break;
  }
  mpu.setGyroRange(MPU6050_RANGE_500_DEG);
  Serial.print("Variação do Giroscópio para: ");
  switch (mpu.getGyroRange()) {
  case MPU6050_RANGE_250_DEG:
    Serial.println("+- 250 deg/s");
    break;
  case MPU6050_RANGE_500_DEG:
    Serial.println("+- 500 deg/s");
    break;
  case MPU6050_RANGE_1000_DEG:
    Serial.println("+- 1000 deg/s");
    break;
  case MPU6050_RANGE_2000_DEG:
    Serial.println("+- 2000 deg/s");
    break;
  }

  mpu.setFilterBandwidth(MPU6050_BAND_21_HZ);
  Serial.print("Filtro: ");
  switch (mpu.getFilterBandwidth()) {
  case MPU6050_BAND_260_HZ:
    Serial.println("260 Hz");
    break;
  case MPU6050_BAND_184_HZ:
    Serial.println("184 Hz");
    break;
  case MPU6050_BAND_94_HZ:
    Serial.println("94 Hz");
    break;
  case MPU6050_BAND_44_HZ:
    Serial.println("44 Hz");
    break;
  case MPU6050_BAND_21_HZ:
    Serial.println("21 Hz");
    break;
  case MPU6050_BAND_10_HZ:
    Serial.println("10 Hz");
    break;
  case MPU6050_BAND_5_HZ:
    Serial.println("5 Hz");
    break;
  }

  Serial.println("");
  delay(100);

 

}

void loop() {

  //Variáveis para leitura do Acelerometro, Giroscopio e Tempratura.
  sensors_event_t a, g, temp;
  mpu.getEvent(&a, &g, &temp);

  //Imprime os valores do acelerometro no monitor serial
  Serial.print("X: ");
  Serial.print(a.acceleration.z +0.5);
  Serial.print("; Y: ");
  Serial.print(a.acceleration.y + 0.20);
  Serial.print("; Z: ");
  Serial.print(a.acceleration.x - 10.21);
  //Serial.println("em  m/s^2");
//Imprime os valores do giroscopio no monitor serial
 // Serial.print("Rotação X: ");
 // Serial.print(g.gyro.x);
  //Serial.print(", Y: ");
  //Serial.print(g.gyro.y);
  //Serial.print(", Z: ");
  //Serial.print(g.gyro.z);
  //Serial.println(" rad/s");
//Imprime os valores do termometro no monitor serial
  //Serial.print("Temperatura: ");
  //Serial.print(temp.temperature);
  //Serial.println(" °C");

  Serial.println("");
  
  //OBS: o eixo X e Z estão invertidos
  sprintf(dados, "X: %.2f; Y: %.2f; Z: %.2f" , (a.acceleration.z +0.5), (a.acceleration.y + 0.20),(a.acceleration.x - 10.21));
  MQTT.publish(MQTT_TOPIC, dados);//Envio dos dados
  setupWifi();
  setupMQTT();
  delay(5); // Atraso definido em milisegundos entre as leituras 
}
