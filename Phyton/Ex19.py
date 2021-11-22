A = float(input("Digite o A: "))
v0= (input("Digite o v0,:"))
t = float(input("Digite o tempo: "))


vf = v0+(A*t)
if(vf<=60):
 if vf <= 40:
     print("Veiculo muito lento")
 else:
     print("Velocidade permitida")

if(vf<=120)and(vf>60):
 if vf <= 80:
     print("Velocidade de cruzeiro")
 else:
     print("Velocidade rápida")
     

else:
  print("Veiculo muito rápida")
  #40 60 80 120