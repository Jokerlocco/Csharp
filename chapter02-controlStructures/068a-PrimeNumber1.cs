// Cristina Francés
// Prime number?

using System;

public class NumeroPrimo
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int dividers = 0;
        
        for (int i=1; i<=num; i++) 
        {
            if (num % i == 0 )
                dividers++;
                
            if( dividers > 2)
            {
                Console.WriteLine("It is not a prime number");
                break;
            }
                
        }
        if (dividers == 2)
            Console.WriteLine("It is a prime number");
    }
}
