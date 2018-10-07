# Jorge Calzada Asenjo
# Python 3.7
# Challenge 1.04 - The Buffer

"""
How many men can use wall-mounted urinals at the same time without breaking
the rule that one must always leave a buffer between a urinal and other
urinal.
"""

'''
Example of entry:
5
1
2
3
4
5

Output for that example:
1
1
2
2
3
'''

import math

cases = int(input())

for value in range(0, case):
    numberUrinals = int(input())
    result = math.ceil(numberUrinals / 2)
    print(result)
