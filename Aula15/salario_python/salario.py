salario = int(input('Digite seu salario: '))

if salario < 500:
    novo_salario = salario * 1.15
elif salario >= 500 and salario < 1000:
    novo_salario = salario * 1.10
else:
    novo_salario = salario * 1.05

print('Seu novo Salário é: {:.2f}'.format(novo_salario))