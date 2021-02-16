#declarar os vetores A e B
vetorA = [1,1,1,1]
vetorB = [1,1,1,1]

#Montar os vetores A e B
for i in range(0, 4, 1):
    vetorA[i] = int(input("Digite um número: "))
    vetorB[i] = vetorA[i] * vetorA[i]

#Exibindo os vetores A e B
for i in range(0, 4, 1):
    print(f'vetorA[{i}] = {vetorA[i]} vetorB[{i}] = {vetorB[i]}')    