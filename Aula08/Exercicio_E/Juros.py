valor = float(input("Digite o valor da compra: "))
taxa = float(input("Digite o valor da taxa: "))
tempo = float(input("Quanto tempo você atrasou: "))

press = valor + (valor * (taxa/100) * tempo)

print("O valor da prestação é {}".format(press))