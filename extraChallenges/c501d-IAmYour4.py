# Adrián Navarro Gabino

cases = int(input())

for i in range(cases):
    name = input()
    relationship = input()
    
    if name != "Luke" or relationship != "padre":
        print(name + ", yo soy tu " + relationship)
    else:
        print("TOP SECRET")
