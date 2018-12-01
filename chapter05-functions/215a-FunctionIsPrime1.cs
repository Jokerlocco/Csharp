// Function IsPrime
// First approach, (very) slow

using System;

public class FunctionIsPrime1
{
    public static bool IsPrime(long number)
    {
        int dividers = 0;
        for (int i = 1; i <= number; i++)
        {
            if(number % i == 0)
                dividers++;
        }
        return dividers == 2;
    }

    public static void Main()
    {
        Console.WriteLine(IsPrime(17));

        if (IsPrime(987654321))
          Console.WriteLine("987654321 is prime");
        else
          Console.WriteLine("987654321 is not prime");
    }
}
