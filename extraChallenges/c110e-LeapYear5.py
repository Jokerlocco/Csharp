'''

   Challenge 1.10 "Gregory XIII" (Acepta 355)
   Checks if a year is a leap year
   
   Python 3.7
   José Vicente Antón Castelló

Example of input
4
1584
1600
1699
1700

Example of output
29
29
28
28

'''

cases = int(input())

for i in range (cases):
   
   year = int(input())
   days = 28
   
   if (year % 4 == 0):
      if (year % 100 == 0):
         if (year % 400 == 0):
            days += 1
            
      else:
         days += 1
         
   print(days)

