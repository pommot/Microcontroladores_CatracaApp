void saveDataBaseOnEeprom () {
  printf(lcd_escreve,"\fBaixando BD");
  delay_ms(2000);
  int16 i;
  int16 j;
  char BD[48];
  
  for( j= 0 ; j<= 48; j++) 
  {
    BD[j] = rx_buffer[j];     
  }
   for(i = 0 ; i<48 ; i++ ) 
   {
      write_ext_eeprom(i, BD[i]);
   }  
   data_users = FALSE;
  printf(lcd_escreve,"\fDigite ID:\r");
}

void handleDeleteUserOnEeprom(){
  inicio:
  printf(lcd_escreve,"\fID para Deletar:\r");
  indexArrayDigitUser = 0;
  int exit = 0;
  while(!exit) {
    tecla = saveCharPressByUser();
    switch (tecla) {
      case 'A': {
          if(memoryUserPosition[indexArrayDigitUser] <=0) {
            printf(lcd_escreve,"\fCampo vazio");
            delay_ms(1000);
            goto inicio;
          }else {
            if(checkExistIDOnEeprom() == 1) {
                deleteUserOnEeprom();
                exit = 1;  
            }else {
                printf(lcd_escreve,"\fID nao existe");
                delay_ms(1000);
                goto inicio;
            }
          }
         break;
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
  //deleteUserEeprom();
} 



void handleEditUser(){
  inicio:
  printf(lcd_escreve,"\fID para editar:\r");
  indexArrayDigitUser = 0;
  int exit = 0;
  while(!exit) {
    tecla = saveCharPressByUser();
    switch (tecla) {
      case 'A': {
          if(memoryUserPosition[indexArrayDigitUser] <=0) {
            printf(lcd_escreve,"\fCampo vazio");
            delay_ms(1000);
            goto inicio;
          }else {
            if(checkExistIDOnEeprom() == 1) {
                telaEdicao();
            }else {
                printf(lcd_escreve,"\fID nao existe");
                delay_ms(1000);
                goto inicio;
            }
          }
         break;
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
  //deleteUserEeprom();
} 


void telaEdicao () {
  printf(lcd_escreve,"\fAlterar Status:\r");
  int exit = 0;
  char status;
  while(!exit) {
    tecla = saveCharPressByUser();
    switch (tecla) {
      case '1': {
         status = '1';
         break;
      }
      case '0': {
         status = '0';
         break;
      }
      case 'A': {
         exit = 1;
         break;
      }
      default: {
        break;
      }
    }
    printf(lcd_escreve,"%c",tecla);
  }
  
   write_ext_eeprom(savePositionForValidID+7,status);
   printf(lcd_escreve,"\f Editado",);
   delay_ms(1500);
 }
int getIdADMOnEeprom(){
   int isEqual=1;
   int j;
  
   for(j=0;j<=2;j++) {
     if(memoryUserPosition[j]!=  read_ext_eeprom(j)) {
         isEqual = 0;
     }
   }
   
   return isEqual;
}

int getPinADMOnEeprom(){
   int isEqual=1;
   int j;
   for(j=3;j<=6;j++) {
      if(memoryUserPosition[j] !=  read_ext_eeprom(j)) {
        isEqual = 0;
      }
   }
   
   return isEqual;
}

void saveSignInEeprom() {
  printf(lcd_escreve,"\fBaixando BD");
  delay_ms(2000);
  int freeSpace = searchFreePositionEeprom() ;
  int j;
  int indexMemoryRAM = 0;

  if(data_avail) {
    for( j= freeSpace ; j<=freeSpace+7 ; j++) {
        write_ext_eeprom(j,rx_buffer[indexMemoryRAM]);
        indexMemoryRAM++;
    }
    data_avail=FALSE;
    printf(lcd_escreve,"\fSalvo! \r");
    printf(lcd_escreve,"\fDigite ID:\r");
    return;
  }else {
    for( j = freeSpace; j<= freeSpace + 7; j++){
        write_ext_eeprom( j, memoryUserPosition[indexMemoryRAM]); 
        indexMemoryRAM++;
    }
    printf(lcd_escreve,"\fCadastro\nefetuado"); 
    delay_ms(100);
  }
}


unsigned int16 searchFreePositionEeprom() {
  int read = 0;
  int i = 0;
  read = read_ext_eeprom(i);
  
  while(read != 0xFF && read != 'x') {
    i+= 8;
    read = read_ext_eeprom(i);
  }
  return i;

}

void deleteUserEeprom() {
    printf(lcd_escreve,"\fDeletando usuario");
    delay_ms(1000);
    int isValid = checkByPc();
    int k;
        if(isValid) {
            for(k=savePositionForValidID;k<= savePositionForValidID+7;k++){
                write_ext_eeprom(k,0xFF);
            }
            printf(lcd_escreve,"\f Deletado!");
            delay_ms(500);
            del = FALSE;
            printf(lcd_escreve,"\fDigite PIN:\r");
            return;
        }else {
            printf(lcd_escreve,"\fUsuario nao\rexiste");
            delay_ms(500);
            del = FALSE;
            printf(lcd_escreve,"\fDigite PIN:\r");
            return;
        }

}

void deleteUserOnEeprom() {
     int k;
     for(k=savePositionForValidID;k<= savePositionForValidID+7;k++){
            write_ext_eeprom(k,0xFF);
        }
        printf(lcd_escreve,"\f Deletado!");
        delay_ms(1000);
}

void editUserEeprom() {
   int isValid = checkByPc();
   
   if(isValid) {
       printf(lcd_escreve,"\fEditando Usuario");
       delay_ms(500);
       write_ext_eeprom(savePositionForValidID+7,rx_buffer[3]);
       printf(lcd_escreve,"\fFinalizado!");
       delay_ms(500);
       edit = FALSE;
       printf(lcd_escreve,"\fDigite ID: \r");
      
       return;
   }else {
      printf(lcd_escreve,"\fID nao existe.");
      delay_ms(1000);
      edit = FALSE;
      printf(lcd_escreve,"\fDigite ID: \r");

      return;
   }

}

int checkDoubleIDEeprom() {
    int hasIDEqual = 1;
    int exit = 0;
    int indexEeprom=1; 
    while(!exit){
      for(i=0;i<=2;i++){
           if(read_ext_eeprom(i+indexEeprom*8 ) != memoryUserPosition[i]) {
              hasIDEqual = 0;
           }
      }
      if(hasIDEqual) {
         exit=1 ;
         savePositionForValidID = indexEeprom *8;
      }else {
         hasIDEqual=1;
         indexEeprom++;
      }
       
      if( indexEeprom == 65) {
       exit =1;
       hasIDEqual = 0 ;
      }
   }
   return hasIDEqual;

}

int checkExistIDOnEeprom()  {
   int isEqual = 1;
   int indexEeprom = 1;
   int exit =0;
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

int checkByPc(){
   int isEqual = 1;
   int indexEeprom = 1;
   int exit =0;
   int g;
   while(!exit){
      for(i=0;i<=2;i++){
           if(read_ext_eeprom(i+(indexEeprom*8) ) != rx_buffer[i]) {
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
