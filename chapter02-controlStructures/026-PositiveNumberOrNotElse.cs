// Is a number positive? (v3: else)

using System;

public class PositiveNumber3
{
	public static void Main()
	{
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if ( n > 0 ) 
			Console.WriteLine("Positive!");
        else
			Console.WriteLine("Negative or zero!");
    }
}

