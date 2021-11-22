v1 = int(input("Digite um número: "))
v2 = int(input("Digite um número maior que o anterior: "))
while(v2 <= v1):
 print("Não pode número menor!")
 v2 = int(input(f"Digite um outro número maior que {v1:.2f}: "))
