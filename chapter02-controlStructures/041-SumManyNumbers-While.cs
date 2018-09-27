// Addition till the user enters 0
// Diego Anibal Lezcano Reissner

using System;

public class Hellow10Times
{    
    public static void Main()
    {
        
        int number;
        int sum = 0;
        
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        
        while(number != 0)
        {
            sum = sum + number;
            Console.Write("Enter another number (0 to exit): ");
            number = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("The sum is: {0}", sum);
    }
}
