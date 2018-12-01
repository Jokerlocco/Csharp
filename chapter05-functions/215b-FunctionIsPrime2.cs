// Function IsPrime
// Second approach, faster

//Ivan Lazcano

using System;

public class FunctionIsPrime
{
    public static bool IsPrime(long number)
    {
        for (int i = 2; i < number/2; i++)
        {
            if(number % i == 0)
                return false;
        }
        return true;
    }

    public static void Main()
    {
        Console.WriteLine(IsPrime(100));

        if (IsPrime(987654321))
          Console.WriteLine("987654321 is prime");
        else
          Console.WriteLine("987654321 is not prime");
    }
}
