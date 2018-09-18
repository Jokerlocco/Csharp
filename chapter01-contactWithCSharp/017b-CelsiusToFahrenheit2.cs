// CelsiusToFahrenheit
// Miguel Isidro Blasco

using System;

public class CelsiusToFahrenheit1
{
    public static void Main()
    {
        int c;
        
        Console.Write("How many Celsius degrees? ");
        c = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("It is equivalent to {0} Fahrenheit", 
            c*18/10.0 + 32);
    }
}
