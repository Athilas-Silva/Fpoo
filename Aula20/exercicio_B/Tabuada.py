num = int(input("Informe um número para a tabuada: "))
contador = 1

while contador < 11:
    print('{} x {} = {}'.format(num, contador, num * contador))
    contador+= 1