// Is a number positive? (v2)

using System;

public class PositiveNumber2
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if ( n > 0 ) 
            Console.WriteLine("Positive!");
            
        if ( n <= 0 ) 
            Console.WriteLine("Negative or zero!");
    }
}

