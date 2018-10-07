// Pablo Sánchez Alonso
// Power
using System;
public class Power
{
    public static void Main()
    {
        Console.WriteLine("Enter the base");
        int bas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the exponent");
        int exp = Convert.ToInt32(Console.ReadLine());
        
        int power = 1;
        for (int i = 0; i < exp; i++)
        {
            power = power * bas;
        }
        Console.WriteLine ("The power is {0}", power);
    }
}

