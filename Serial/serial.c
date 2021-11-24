//#include "C:\Users\João\Desktop\AAAA\main.h"
#include "config.c"
#include "funcoesEeprom.c"
#include "ultilidades.c"
//============================ VOID [MAIN]================================

void main () {
  BYTE value,value_recebido, cmd;
  EEPROM_ADDRESS address;
  
  unsigned int i=0,tensao=0; signed int y=-50; 
  setup_adc(ADC_CLOCK_DIV_16); 
  setup_adc_ports(AN0);
  setup_psp(PSP_DISABLED); 
  setup_spi(SPI_SS_DISABLED); 
  setup_timer_0(RTCC_INTERNAL|RTCC_DIV_1);
  setup_timer_1(T1_DISABLED); 
  setup_timer_2(T2_DISABLED,0,1); 
  setup_comparator(NC_NC_NC_NC);
  setup_vref(FALSE);
  enable_interrupts(INT_RDA); 
  enable_interrupts(GLOBAL);
  set_adc_channel(0);
  output_low(PIN_D2);
  output_low(PIN_D3);  
  
  init_ext_eeprom();
  lcd_ini();
  
  printf(lcd_escreve,"\fIniciando...");
  delay_ms(2000);
  clearRAM();
  
  int j;
  for(j = 0 ; j<255 ; j++ ) {
      write_ext_eeprom(j,0xFF);
  }
  
  
  // Cadastra o primeiro Usuario(ADM)========== 
      handleVerifySignInAdm();
  //===========================================  
  
  while(1){
  
    switch(screen) {
      case 0:{
         home();
         break;
      }
      case 1:{
         menu();
         break;
      }
      default:{
         printf(lcd_escreve,"\fDeu tudo errado");
         break;
      }
   }
 } 
 

}

//=======================================================================


//============================Funçoes====================================
void home(){
  inicio:
  handeInputsIDByUser();  
  if(screen == 1) return;
  if(checkId() == 0) {
   printf(lcd_escreve,"\fID nao existe");
   delay_ms(1500);
   goto inicio;
  }
  // 0 = home  screen == 0 ||
   handleSavePinOnRam();
   if(checkPIN() == 1){
         if(isUserOk == 1) {
            printf(lcd_escreve,"\fAcesso\rAutorizado!");
            delay_ms(1500);
         } else{
            printf(lcd_escreve,"\fCadastro Expirado");
            delay_ms(1500);
            return;
         }
   }else {
         printf(lcd_escreve,"\fPIN incorreto");
         delay_ms(3000);
         goto inicio;
      }
  
 clearRAM();
}
 
void menu(){
   int acessoAoMenu = 0; // 0 = negado;
   printf(lcd_escreve,"\fAcesso Restrito");
   delay_ms(1500);
   printf(lcd_escreve,"\fNecessario Logar");
   delay_ms(1500);
   inicio:
   handeInputsIDByUser();
   
   if(!getIdADMOnEeprom()){
      printf(lcd_escreve,"\fID nao existe ");
      delay_ms(1500);
      goto inicio;
   }else {
      handleSavePinOnRam();
      if(!getPinADMOnEeprom()) {
         printf(lcd_escreve,"\fPIN Errado");
         delay_ms(1500);
         goto inicio;

      }else {
         printf(lcd_escreve,"\fAcesso Autorizado");
         delay_ms(1500);
         acessoAoMenu = 1;
      }
   }
 
   
   if(acessoAoMenu) {
      int exit = 0;
      int indexMenu = 0;
      char tecla;
      printf(lcd_escreve,"\f%s",admMenu[indexMenu]);
      while(!exit) {
        tecla = saveCharPressByUser (); 
        switch(tecla) {
           case '4': {
               if(indexMenu<=0){
                  indexMenu = 2 ;
               }else {
                  indexMenu--;
               }
               break;
           }
           case '6': {
            if(indexMenu >=2) {
               indexMenu = 0;
            }else {
               indexMenu++;
            }
            break;
           }
           case 'A':{
               if(indexMenu == 0 ) {
                  printf(lcd_escreve,"\fRedirecionar\rCadastro");
                  cadastro = 1;
                  delay_ms(1500);
                  signIn();
                  clearRAM();
                  cadastro = 0;
               }else if (indexMenu == 1) {
                  printf(lcd_escreve,"\fRedirecionar Deletar");
                  delay_ms(1500);
                  handleDeleteUserOnEeprom();
               }else if (indexMenu == 2 ) {
                  printf(lcd_escreve,"\fRedirecionar Deletar");
                  delay_ms(1500);
                  handleEditUser();
               }
               break;
           }
           case '*': {
            exit =1;
            screen = 0; // 0 => Home
            break;
           }
           default: {
            break;
           }
        }
       printf(lcd_escreve,"\f%s",admMenu[indexMenu]);
       delay_ms(100);
      }
   }
}



void handleVerifySignInAdm () {
    int j;
    for(j=0;j<=2;j++) {
        if(read_ext_eeprom(j) == 0xFF) {
            firstAdm = 1;
        }
    }
    while(firstAdm) {
      printf(lcd_escreve,"\fSem ADM");
      delay_ms(3000);
      printf(lcd_escreve,"\fCadastre agora");
      delay_ms(1500);
      signIn(); 
    }
}



void signIn() {
  clearRAM();
  handeInputsIDByUser();
  handleSavePinOnRam();
  memoryUserPosition[7]="1"; // Todo novo usuario que faz cadastro já é aceito como valido, caso deixei de pagar tera como alterar isso.
  if( !firstAdm ) {
     saveSignInEeprom();
  }else {
    saveSignInEeprom();
    firstAdm = 0;
    screen=0; // 0 = home
  }
}
 


