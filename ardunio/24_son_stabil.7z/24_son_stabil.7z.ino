#include <SPI.h>
#include <MFRC522.h>


#define SS_PIN 10 // SDA pin
#define RST_PIN 9 // Reset pin


MFRC522 mfrc522(SS_PIN, RST_PIN);


void setup() {
  Serial.begin(9600);
  SPI.begin();
  mfrc522.PCD_Init();
  Serial.println("Yurt otomasyon sistemi başlatıldı");
  Serial.println("Lütfen Kartınızı Okutunuz...");
  Serial.println();

}

void loop() {

  if (! mfrc522.PICC_IsNewCardPresent()) {
    return;
  }


  if (! mfrc522.PICC_ReadCardSerial()) {
    return;
  }
  
  String cardUID = "";

  for (byte i =0 ; i < mfrc522.uid.size; i ++) {
    cardUID += (mfrc522.uid.uidByte[i] < 0x10 ? "0" : "") + String(mfrc522.uid.uidByte[i], HEX);

  }


  cardUID.toUpperCase();
  cardUID.trim();

  Serial.println(cardUID);

  mfrc522.PICC_HaltA();

}
