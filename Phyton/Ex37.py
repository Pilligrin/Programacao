N = int(input("Digite um número positivo, menor que 20: "))
while(N <= 0)or(N>20):
 print("Não pode número negativo!")
 N = int(input("Digite um outro número positivo, menor que 20: "))

numeros = []
m=1

for i in range(0, N, 1):
 x = int(input('Digite um numero: '))
 numeros.append(x)

while(m==1):
 en = int(input('Digite um numero para encontrar: '))
 for i in range(0, N, 1):
   if(en==numeros[i]):
    print(f'Posição: {i}')
    contagem=0

 if(contagem==1):
     print(f'Valor não encontrado!') 
     m = int(input('Digite 1 para procurar por um outro valor, ou 0 para não procurar:'))
