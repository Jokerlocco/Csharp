//  Daniel Contreras 

using System;

public class Multiply3numbers
{
    public static void Main()
    {
        int n1, n2, n3;
        
        Console.Write("Enter the first number: ");
        n1 = Convert.ToInt32( Console.ReadLine() );        
        Console.Write("Enter the second number: ");
        n2 = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter the third number: ");
        n3 = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("Their product is ");
        Console.WriteLine( n1*n2*n3 );
    }
}
