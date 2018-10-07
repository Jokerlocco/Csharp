# Adrián Navarro Gabino
# Challenge 1.05: Side of the street

# Input sample
# 3
# 10
# 41
# 0
# 
# Output
# IZQUIERDA
# DERECHA
# IZQUIERDA


streetNumber = 1

while streetNumber != 0:
    streetNumber = int(input())
    if streetNumber != 0 and streetNumber % 2 == 0:
        print("DERECHA")
    elif streetNumber % 2 == 1:
        print("IZQUIERDA")
