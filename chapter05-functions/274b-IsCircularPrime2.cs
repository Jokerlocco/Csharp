// Jorge Calzada Asenjo

using System;

public class CircularPrime
{
    public static bool IsPrime(long num)
    {
        int i = 2;
        bool prime = true;

        while (i < num / 2 && prime)
        {
            if (num % i == 0)
                prime = false;

            i++;
        }

        return prime;
    }

    public static bool IsCircularPrime(long num)
    {
        bool circularPrime = true;
        int i = 0;
        string numberString = num.ToString();

        circularPrime = IsPrime(num);

        while (i < num.ToString().Length && circularPrime)
        {
            numberString = numberString.Substring(1) + numberString[0];
            circularPrime = IsPrime(Convert.ToInt64(numberString));

            i++;
        }

        return circularPrime;
    }

    public static void Main()
    {
        Console.Write("Enter a number: ");
        long x = Convert.ToInt64( Console.ReadLine() );
        if (IsCircularPrime(x))
            Console.WriteLine( x + " is a circular prime");
        else
            Console.WriteLine( x + " is not a circular prime");
    }
}
