// Difference of two numbers
// Araceli Yáñez

using System;

public class DifferenceOfTwoNumbers
{
    public static void Main()
    {
        int num1, num2, difference;
        
        Console.Write( "First number: " );
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write( "Second number: " );
        num2 = Convert.ToInt32(Console.ReadLine());
        
        difference = num1-num2;
        
        Console.Write( "The difference is: " );
        Console.WriteLine( difference );
    }  
}
