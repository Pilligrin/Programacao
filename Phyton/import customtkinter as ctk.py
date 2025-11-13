import customtkinter as ctk
import serial
import threading
import time

# Configuração da janela principal
ctk.set_appearance_mode("dark") # "light" ou "dark"
ctk.set_default_color_theme("blue")

app = ctk.CTk()
app.title("Leitor de Sinal Analógico")
app.geometry("500x200")

# Configuração da porta serial (ajuste a porta e baudrate conforme o Arduino)
ser = serial.Serial('COM5', 9600)  
# Label para mostrar o valor
valor_label = ctk.CTkLabel(app, text="Valor: --", font=("Arial", 20)) 
valor_label.pack(pady=20)

# Variável de controle do loop
rodando = False
Leitura = True


def ler_serial():
     global rodando
     while rodando and ser:
       try:
              while Leitura:
                 #lê dados na fila
                 dado = ser.readline()
                 dadostring = dado.decode('utf-8').strip()
                 if dadostring:
                   print("Recebido:",dadostring)  
                 app.after(0, lambda: valor_label.configure(text=f"{dadostring}"))

       except KeyboardInterrupt:
         print("Fim")
         
      
def iniciar():
     
     if(ser.is_open == False):
          ser.open()
        
     global rodando
     if not rodando:
       rodando = True
     thread = threading.Thread(target=ler_serial, daemon=True)
     thread.start()

def parar():
        global  rodando
        leitura = False
        if KeyboardInterrupt:
         ser.close()
rodando = False

# Botões
btn_iniciar = ctk.CTkButton(app, text="Iniciar Leitura", command=iniciar)
btn_iniciar.pack(pady=10)

btn_parar = ctk.CTkButton(app, text="Parar Leitura", command=parar)
btn_parar.pack(pady=5)

# Loop principal
app.mainloop()
