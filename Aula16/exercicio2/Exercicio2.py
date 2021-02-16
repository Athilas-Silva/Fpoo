x = float(input("Digite um valor: "))

if x > 0:{
    print("POSITIVO")
}
elif x < 0:{
    print("NEGATIVO")
}
else:{
    print("NEUTRO")
}

print("PAR" if x % 2 == 0 else "IMPAR")