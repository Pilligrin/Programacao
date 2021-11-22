numeros = []
for i in range(0, 10, 1):
 x = int(input('Digite um numero: '))
 numeros.append(x)
print('Os numeros que você digitou foram: ')
for i in range(9, -1, -1):
 print(numeros[i])