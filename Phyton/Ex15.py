peso = float(input("Digite o peso: "))
altura = float(input("Digite a altura: "))


imc = peso/(altura*altura)

if imc < 20:
 print("Abaixo do peso!")
elif imc < 25:
 print("Peso ideal!")
else:
 print("Acima do peso!")