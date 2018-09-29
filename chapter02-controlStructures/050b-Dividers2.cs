// Dividers of a number (v2)
// Adrián Navarro Gabino

using System;

public class Dividers2
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int limit = n/2;
        
        Console.Write("Its dividers are: 1, ");
        for(int i = 2; i <= limit; i++)
        {
            if(n % i == 0)
                Console.Write("{0}, ", i);
        }
        Console.WriteLine("and {0}.",n);
    }
}
