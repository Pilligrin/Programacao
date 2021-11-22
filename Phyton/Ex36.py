numeros = []
for i in range(0, 20, 1):
 x = int(input('Digite um numero: '))
 numeros.append(x)

k = int(input('Digite uma constante: '))
for i in range(0, 20, 1):
  numeros[i]=numeros[i]*k
  print(f'{numeros[i]}')
  