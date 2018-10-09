# Challenge 1.06: "Counting in the sand" (base 1)
# Python solution 1: "for", C style

n = int(input())
while n != 0:
    for i in range(0,n):
        print("1", end="")
    print()
    n = int(input())
