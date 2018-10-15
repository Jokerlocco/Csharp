# Jorge Calzada Asenjo
# Challenge 1.09 - Team lunch
# Python3.7 version

'''
    Calculate the number of tables needed for the team lunch
'''

'''
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
'''

t = int(input())

for cases in range(1, t+1):
    n = int(input())
    print("Case #", cases, ": ",
        (1 if (n < 5 and n > 0) else int((n - 1) / 2)), sep='')
