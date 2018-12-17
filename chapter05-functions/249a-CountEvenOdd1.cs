// Diego Aníbal Lezcano Reissner

using System;
using System.Text;


class EvenOdds
{
    static void CountEvenOdd(int n, ref int odds, ref int evens)
    {
        string nStr = Convert.ToString(n);
        for(int i = 0;i < nStr.Length;i++)
        {
            if (nStr[i] % 2 == 0)
            {
                evens++;
            }
            else
            {
                odds++;
            }
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

