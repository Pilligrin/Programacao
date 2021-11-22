v1 = float(input("Digite o valor 1: "))
v2 = float(input("Digite o valor 2: "))
v3 = float(input("Digite o valor 3: "))


if((v1+v2)>v3)or((v1+v3)>v2)or((v2+v3)>v1):
     print("É um triângulo")
elif (v1==v2)and(v1==v3):
    print("É um equilatero")
elif ((v1==v2)and(v1!=v3))or((v2==v3)and(v2!=v1))or((v1==v3)and(v1!=v2)):
    print("É um isoceles")
elif ((v1!=v2)and(v1!=v3))and((v2!=v3)):
     print("É um escaleno")       
else:
    print("Não é um triângulo")