# Jorge Calzada Asenjo
# Challenge 471: Looking for the puncture
# Python 3.7 version

'''
    If you put a wheel with a puncture in water, knowing the angle at
    which we put it and where the hole is, calculate where it would be
    better to turn or if it would not matter.
'''

'''
    Example of input
    3
    90
    91
    0
    359
    0
    180


    Example of output
    ASCENDENTE
    DESCENDENTE
    DA IGUAL
'''

cases = int(input())

for i in range(0, cases):
    startingAngle = int(input())
    puncture = int(input())
    diff = startingAngle - puncture

    if (diff == 0 or diff == -180 or diff == 180):
        print("DA IGUAL");
    elif ((diff < 0 and diff > -180) or (diff > 180)):
        print("ASCENDENTE")
    else:
        print("DESCENDENTE")
