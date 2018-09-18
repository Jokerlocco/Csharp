// CelsiusToFahrenheit
// Miguel Isidro Blasco

using System;

public class CelsiusToFahrenheit1
{
    public static void Main()
    {
        int c, f;
        
        Console.Write("How many Celsius degrees? ");
        c = Convert.ToInt32(Console.ReadLine());
        
        f = c*18/10 + 32;
        Console.WriteLine("It is equivalent to {0} Fahrenheit", f);
    }
}
