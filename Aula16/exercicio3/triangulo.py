a = float(input("Digite o primeiro valor: "))
b = float(input("Digite o segundo valor: "))
c = float(input("Digite o terceiro valor: "))

if a == b and b == c:
    print("Triângulo Equilátero")

elif a == b or a == c or b == c:
    print("Triângulo Isósceles")

else:
    print("Triângulo Escaleno")