num = int(input("Digite um número para obter a tabuada: "))
v1= int(input("Digite o inicio do intervalo: "))
v2= int(input("Digite o final do intervalo: "))

while(num <= 0):
 print("Não pode número negativo!")
 num = int(input("Digite um outro número para obter a tabuada: "))

for i in range(v1, v2+1, 1):
 r = num * i
 print(f'{num} X {i} = {r}')