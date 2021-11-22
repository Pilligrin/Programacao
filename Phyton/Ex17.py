C = float(input("Digite o valor C: "))
B = float(input("Digite o valor B: "))
A = float(input("Digite o valor A: "))

#OBSERVAÇÃO a hipotenusa sempre é o maior lado
if (B>C)and(B>A):
  maior=B
  m1=A
  m2=C
if (C>B)and(C>A):
  maior=C
  m1=A
  m2=B
if (A>B)and(A>C):
  maior=A
  m1=B
  m2=C
else:
  maior=A
  m1=B
  m2=C
if((m1*m1)+(m2*m2)==(maior*maior)):
     print("É um triângulo retângulo")
       
else:
    print("Não é um triângulo retângulo")