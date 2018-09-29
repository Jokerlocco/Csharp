// Is a number prime? (v1)

using System;

public class IsPrime
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int dividers = 0;
        
        for(int i = 1; i <= n; i++)
        {
            if(n % i == 0)
                dividers++;
        }
        if (dividers == 2)
            Console.WriteLine("It is a prime");
        else
            Console.WriteLine("It is not a prime");
    }
}
