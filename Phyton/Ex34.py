numeros = []
for i in range(0, 10, 1):
 x = int(input('Digite um numero: '))
 numeros.append(x)
maior=numeros[1]#ter uma base

for i in range(0, 10, 1):
 if(numeros[i]>maior):
  maior=numeros[i]

print(f'O maior dos numeros digitados foi: {maior} ')