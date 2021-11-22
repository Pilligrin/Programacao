peso = float(input("Digite o peso: "))
sexo= (input("Digite o sexo, m (Masculino) ou f (Feminino):"))
altura = float(input("Digite a altura: "))


imc = peso/(altura*altura)
if(sexo=="m"):
 if imc < 20:
     print("Abaixo do peso!")
 elif imc < 25:
     print("Peso ideal!")
 else:
     print("Acima do peso!")

if(sexo=="f"):
 if imc < 19:
     print("Abaixo do peso!")
 elif imc < 24:
     print("Peso ideal!")
 else:
     print("Acima do peso!")

