#include <16F877A.h>
#device ADC=10

#FUSES WDT                   	//Watch Dog Timer

#use delay(crystal=20000000,restart_wdt)
#use rs232(baud=9600,parity=N,xmit=None,rcv=None,bits=8,stream=PORT1,restart_wdt)

