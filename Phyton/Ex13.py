l1 = float(input("Digite a base do retângulo: "))
l2 = float(input("Digite a altura do retângulo: "))
a = (l1*l2)
print(f"A área do retângulo é de: {a:.2f} unidade de área")
if a>100:
  print("Terreno Grande")
else:
  print("Terreno Pequeno")