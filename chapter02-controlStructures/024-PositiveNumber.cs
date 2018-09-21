// Is a number positive? (v1)

using System;

public class PositiveNumber
{
    public static void Main()
   {
        int n;
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        if ( n > 0 ) Console.WriteLine("Positive!");
    }
}

