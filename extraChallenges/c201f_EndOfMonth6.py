# Adrián Navarro Gabino

casosPrueba = int(input())

for i in range(casosPrueba):
    dinero = [int(x) for x in input().split()]
    print("SI" if (dinero[0] + dinero[1] >= 0) else "NO")
