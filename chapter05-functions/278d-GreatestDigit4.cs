// Greatest digit of a long integer number
// Diego Aníbal Lezcano Reissner

using System;

class Digitogreatest
{
    public static byte GreatestDigit(long n)
    {
        long greatest = n % 10;
        n /= 10;

        while(n > 0)
        {
            if (n % 10 > greatest)
            {
                greatest = n % 10;
            }

            n /= 10;
        }
        return (byte) greatest;
    }

    static void Main(string[] args)
    {
        Console.Write(GreatestDigit(32)); // Should display 3

        if (GreatestDigit(276) != 7)
            Console.WriteLine("Something is not right!");
    }
}

