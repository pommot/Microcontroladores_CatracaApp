
#include <16F877A.h>
#device adc=8
#FUSES HS                       //High speed Osc (> 4mhz for PCM/PCH) (>10mhz for PCD)
#FUSES NOPUT                    //No Power Up Timer
#FUSES NOPROTECT                //Code not protected from reading
#FUSES NODEBUG                  //No Debug mode for ICD
#FUSES NOBROWNOUT               //No brownout reset
#FUSES NOLVP                    //No low voltage prgming, B3(PIC16) or B5(PIC18) used for I/O
#FUSES NOCPD                    //No EE protection
#FUSES NOWRT                    //Program memory not write protected

#use delay(clock=20000000)
#use rs232(baud=9600,parity=N,xmit=PIN_C6,rcv=PIN_C7,bits=8,stream=Wireless)

//===================== Bibliotecas============================= 

#ifndef lcd_enable
#define lcd_enable     pin_E1      // pino enable do LCD
#define lcd_rs         pin_E2      // pino rs do LCD
//#define lcd_rw      pin_e2      // pino rw do LCD
#define lcd_d4         pin_d4      // pino de dados d4 do LCD
#define lcd_d5         pin_d5      // pino de dados d5 do LCD
#define lcd_d6         pin_d6      // pino de dados d6 do LCD
#define lcd_d7         pin_d7      // pino de dados d7 do LCD
#endif

#include "mod_lcd.c"
#include "kbd_ext_board2.c"
#include "2401.c"

#define RX_BUFFER_SIZE 60
int8 rx_wr_index = 0; 
int8 lock_state = 0, rxd,lido, valid_data_count; 
unsigned int8 rx_buffer[RX_BUFFER_SIZE];
int1 data_avail = FALSE, got_id = FALSE,del = FALSE,got_del=FALSE,edit,got_edit=FALSE,got_all_users=FALSE,data_users=FALSE;

//==============================================================

 


//======================= Protótipos ===============================
void handleVerifySignInAdm(void);
void signIn(void);
char saveCharPressByUser (void); 
void saveSignInEeprom(void);
unsigned int16 searchFreePositionEeprom(void);
unsigned int16 searchXPositionOnEeprom(void);
void handeInputsIDByUser(void);
void deleteIDonRAM(void);
void handleSavePinOnRam(void);
void deletePINonRAM(void);
void home(void);
void menu(void);
int getIdADMOnEeprom(void);
int getPinADMOnEeprom(void);
void clearRAM(void);
int checkId(void);
int checkPIN(void) ;
void deleteUserOnEeprom(void);
int getQtdUsersOnEeprom(void);
void deleteUser(void);
void deleteUserEeprom(void);
int checkByPc(void);
void handleDeleteUserOnEeprom(void);
void editUserEeprom(void);
int checkExistIDOnEeprom(void);
void deleteUserOnEeprom(void);
void handleEditUser(void);
void telaEdicao(void);
void receberBancoDeDados(void);
void saveDataBaseOnEeprom (void);
//====================================================================


//======================Variáveis globais/============================

const char admMenu[3][10] = {"Cadastrar","Deletar","Editar"};
int indexArrayDigitUser; // Essa var funciona como index do vetor que armazena oque o usuario digitou.
unsigned int16 i = 0;
unsigned char  memoryUserPosition[8];  
int firstAdm;
char tecla;
int screen = 0;
int savePositionForValidID=1;
int isUserOk; 
int deleteByPIC;
int cadastro = 0;
int qtdDeUsuariosJaCadastrado=1;



char received; 
int1 interrupt_flag=0;
typedef struct  
{
char id[3];
char senha[4]; 
char status; 

} Cliente;  
Cliente C1; 


/*
   0 = home
   1 = menu
*/

//==========================================================================


//========================PORTA SERIAL======================================

#int_RDA 
void RDA_isr(void){ 
    rx_buffer[rx_wr_index] = getc();
    rxd = rx_buffer[rx_wr_index];
    rx_wr_index++;

    if (rx_wr_index > RX_BUFFER_SIZE) {
     rx_wr_index = 0;
    }

    if (rxd == 'C'){     
        got_id = TRUE; 
        valid_data_count = 0; 
        rx_wr_index = 0;
    }
    if (got_id  && valid_data_count++ >= 8){
        data_avail = TRUE;
        got_id = FALSE;
    }


    if (rxd == 'K'){     
        got_all_users = TRUE; 
        valid_data_count = 0; 
        rx_wr_index = 0;
    }
    if (got_all_users  && valid_data_count++ >= 8){
        data_users = TRUE;
        got_all_users = FALSE;
    }

    
    if (rxd == 'D'){     
        got_del = TRUE; 
        valid_data_count = 0; 
        rx_wr_index = 0;
    }else if(got_del && valid_data_count++ >=2) {
        del = TRUE;
        got_del = FALSE;
    }

    if (rxd == 'S'){     
        got_edit = TRUE; 
        valid_data_count =0; 
        rx_wr_index = 0;
    }else if(got_edit && valid_data_count++ >=3) {
        edit = TRUE;
        got_edit = FALSE;
    }
}

//============================================================================
