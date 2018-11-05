# Adrián Navarro Gabino

casosPrueba = int(input())

for i in range(casosPrueba):
    try:
        datos = [x for x in input().split()]
        datos[0] = int(datos[0])
        datos[2] = int(datos[2])
        resultado = {"+": datos[0] + datos[2],
                    "-": datos[0] - datos[2],
                    "*": datos[0] * datos[2],
                    "/": datos[0] // datos[2]}
        print(resultado[datos[1]])
    except:
        print("ERROR")
