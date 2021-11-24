

char saveCharPressByUser () {
  char actualChar = 255;
  
  while(actualChar == 255) {
        if(data_avail) {
            saveSignInEeprom();
        } else if(del){
            deleteUserEeprom();
        }else if(edit){
            editUserEeprom();
        }else if (data_users) {
            saveDataBaseOnEeprom();
        }
        
        actualChar = tc_tecla(500);
    }
  return actualChar;
}


void handeInputsIDByUser() {
  inicio:
  printf(lcd_escreve,"\fDigite ID: \r");

  indexArrayDigitUser = 0;
  int exit = 0;
 
  while(!exit) {
    tecla = saveCharPressByUser();
    switch (tecla) {
      case 'A': {
          if(indexArrayDigitUser<=0 ) {
            printf(lcd_escreve,"\fCampo em Branco.");
            delay_ms(1000);
            printf(lcd_escreve,"\fDigite ID: \r");
          }else {
             if(cadastro == 1) {
                if(checkDoubleIDEeprom() == 1) {
                  printf(lcd_escreve,"\fID ja existe");
                  delay_ms(1000);
                  goto inicio;
               }else {
                  exit = 1;
               }
             }else {
               exit = 1;
             }
            
            break;
         }
      }
      case 'C':  {
        indexArrayDigitUser = 0 ;
        deleteIDonRAM();
        break;
      }
      case '*': {
         exit=1;
         screen=1; // 1 = menu 
      }
      default: {
        if(indexArrayDigitUser<=2) {
          printf(lcd_escreve,"%c",tecla);
          memoryUserPosition[indexArrayDigitUser] = tecla;
          indexArrayDigitUser++;
        }
        break;
      }
    }
  }
}

void  handleSavePinOnRam() {
   indexArrayDigitUser = 3;
   int exit = 0 ;
   printf(lcd_escreve,"\fPIN:\r");
   while(!exit) {
      tecla = saveCharPressByUser ();
      switch(tecla) {
         case 'A': {
            if(indexArrayDigitUser<=3) {
                printf(lcd_escreve,"\f Senha obrigatoria");
                delay_ms(1000);
                printf(lcd_escreve,"\fPIN:\r");

            }else {
               exit = 1;
            }
            break;
         }
         case 'C':  {
           indexArrayDigitUser = 3 ;
           deletePINonRAM();
           break;
         }
         default: {
           if(indexArrayDigitUser<=6) {
             printf(lcd_escreve,"%c",tecla);
             memoryUserPosition[indexArrayDigitUser] = tecla;
             indexArrayDigitUser++;
           }
           break;
         }
      }
   }
}


int checkId(){
   int isEqual = 1;
   int indexEeprom = 1;
   int exit =0;
   int g;
   while(!exit){
      for(i=0;i<=2;i++){
           if(read_ext_eeprom(i+indexEeprom*8 ) != memoryUserPosition[i]) {
              isEqual = 0;
           }
      }
      if(isEqual) {
         exit=1 ;
         savePositionForValidID = indexEeprom *8;
      }else {
         isEqual=1;
         indexEeprom++;
      }
       
      if( indexEeprom == 65) {
       exit =1;
       isEqual = 0 ;
      }
   }
   
   return isEqual ;
}

int checkPIN() {
   int indexMemoryRAM=3;
   int isEqual = 1;
   int j;
   int indexEeprom = savePositionForValidID + 3;
   for(j=indexEeprom;j<=indexEeprom + 3 ; j++){
      if(read_ext_eeprom(j) != memoryUserPosition[indexMemoryRAM]) {
         isEqual = 0;
      }
      indexMemoryRAM++;
   }
   if(isEqual == 1) {
      if(read_ext_eeprom(indexEeprom+4)== '1') {
         isUserOk = 1;
      }else {
         isUserOk = 0;
      }
    
      
   }
   return isEqual;
}

void clearRAM() {
   int j;
   for(j=0;j<=7;j++){
      memoryUserPosition[j] = 0xFF;
   }
}

void deleteIDonRAM() {
   int i;
   for(i=0;i<=2;i++) {
     memoryUserPosition[i] = 0xFF; 
   }
   printf(lcd_escreve,"\fDigite ID:\r");
}

void deletePINonRAM() {
   int i;
   for(i=3;i<=6;i++) {
     memoryUserPosition[i] = 0xFF; 
   }
   printf(lcd_escreve,"\fDigite PIN:\r");

}
