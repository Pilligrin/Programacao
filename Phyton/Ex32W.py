N = int(input("Digite um número positivo, menor que 100: "))
while(N <= 0)or(N>100):
 print("Não pode número negativo!")
 N = int(input("Digite um outro número positivo, menor que 100: "))
v1=1
print(f' {v1} ')
j=1
implementa=3
if(N>1):
 while(j<=N):

   v2=v1+implementa
   implementa=implementa+2
   j=j+1
   print(f' {v2} ')