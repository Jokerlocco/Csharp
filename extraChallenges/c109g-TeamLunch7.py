"""

 Reto 1.09: "Comida en equipo"
 Python 3.7
 José Vicente Antón Castelló

Sample input
6
4
6
5
3
26073
59794

Sample output
Case #1: 1
Case #2: 2
Case #3: 2
Case #4: 1
Case #5: 13036
Case #6: 29896
 
"""

T = int(input())

for t in range (1, T + 1):
    n = int(input())
    r = 1 if n <= 4 else (n - 1) // 2
    print("Case #", t, ": ", r)
