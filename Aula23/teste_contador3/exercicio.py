v_inicial = float(input("Informe o valor inicial: "))
v_final = float(input("Informe o valor final: "))
passo = float(input("Informe o incremento ou decremento: "))

if v_inicial <= v_final:
    while v_inicial <= v_final:
        print("A contagem é: {}".format(v_inicial))
        v_inicial += passo

elif v_inicial >= v_final:
    while v_inicial >= v_final:
        print("A contagem é: {}".format(v_inicial))
        v_inicial = v_inicial - passo      