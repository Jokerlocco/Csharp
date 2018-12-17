using System;
using System.Text;

class EvenOdds2
{
    static void CountEvenOdd(int n, ref int odds, ref int evens)
    {
        while (n > 0)
        {
            int lastDigit = n% 10;

            if (lastDigit % 2 == 0)
                evens++;
            else
                odds++;
            
            n /= 10;            
        }
    }
    
    static void Main(string[] args)
    {
        int evens = 0, odds = 0;

        CountEvenOdd(123456777, ref odds, ref evens);
        Console.WriteLine("Even digits = " + evens);
        Console.WriteLine("Odd digits = " + odds);
    }
}

