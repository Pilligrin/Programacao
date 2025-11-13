import serial
import time
 
#Código para leitura da Serial, para parar a leitura clique no terminal e pressione Ctrl+C

# Cria a conexão (ajusta a porta e o baudrate conforme seu dispositivo)
ser = serial.Serial('COM5', 9600)  
 
print("Conectado na porta:", ser.name)
 
Leitura = True
try:
            while Leitura:
                 #lê dados na fila
                 dado = ser.readline()
                 dadostring = dado.decode('utf-8').strip()
                 if dadostring:
                   print("Recebido:",dadostring)          
except KeyboardInterrupt:
    print("Saindo")
finally:
    ser.close()