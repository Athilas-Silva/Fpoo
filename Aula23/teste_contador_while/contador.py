v_inicial = int(input("Informe o valor inicial: "))
v_final = int(input("Informe o valor final: "))
passo = int(input("Informe o incremento: "))

while v_inicial <= v_final:
    print("A contagem é: {}".format(v_inicial))
    v_inicial += passo