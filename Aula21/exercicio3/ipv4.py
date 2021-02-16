ip4 = int(input("Informe seu ipv4: "))

if ip4 >=1 and ip4 <= 120:
    print('Seu IPV4 é de classe A')

elif ip4 >= 128 and ip4 <= 191:
    print('Seu IPV4 é de classe B') 

elif ip4 >= 192 and ip4 <= 223:
    print('Seu IPV4 é de classe C')

else:
    print('IPV4 Não definido')