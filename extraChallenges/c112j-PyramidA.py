# Jorge Calzada Asenjo
# Challenge 1.12: Pyramid of marbles
# Python 3.7 version

'''
    To calculate how many marbles form a pyramid with triangular base knowing
    the height of the pyramid.
'''

'''
    Example of input
    4
    1
    2
    3
    4


    Example of output
    1
    4
    10
    20
'''

cases = int(input())

for i in range(0, cases):
    height = int(input())

    totalPyramid = int((height * (height + 1) * (height + 2)) / 6);

    print(totalPyramid)
