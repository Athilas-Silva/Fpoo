sm = float(input("Informe o seu salário: "))
pr = float(input("Informe a taxa de acréscimo: "))
ns = sm * pr / (100)

print('O acréscimo será de R$ %.2f'%ns)
print('O novo salário será R$ %.2f'%(sm + ns))