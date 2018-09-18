//  Daniel Contreras 

using System;

public class Multiply3numbers2
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
        
        Console.WriteLine(
            "Their product is {0}", 
            n1*n2*n3 );
    }
}
