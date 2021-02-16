vetorA = [1,1,1,1]
vetorB = [1,1,1,1]
vetorC = [1,1,1,1]

for x in range(0, 4, 1):
    vetorA[x] = int(input("Digite um número para o VetorA: "))
    vetorB[x] = int(input("Digite um número para o VetorB: "))
    vetorC[x] = vetorA[x] - vetorB[x]

for x in range(0, 4, 1):
    print(f'indice {x} -> vetorA = {vetorA[x]} = vetorB = {vetorB[x]} = vetorC = {vetorC[x]}')    