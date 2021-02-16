oit = int(input("Informe o primeiro digito: "))
seti = int(input("Informe o segundo digito: "))
sex = int(input("Informe o terceiro digito: "))
quin = int(input("Informe o quarto digito: "))
quar = int(input("Informe o quinto digito: "))
ter = int(input("Informe o sexto digito: "))
seg = int(input("Informe o setimo digito: "))
pri = int(input("Informe o oitavo digito: "))

res = pri + (seg * 2) + (ter * 4) + (quar * 8) + (quin * 16) + (sex * 32) + (seti * 64) + (oit * 128)

print('O número em decimal é {}'.format(res))