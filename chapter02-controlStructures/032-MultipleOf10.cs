// Multiple of 10?

using System;

public class MultipleOf10
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if ( n % 10 == 0) 
            Console.WriteLine("It is a multiple of 10");
        else
            Console.WriteLine("It is not a multiple of 10");
    }
}

