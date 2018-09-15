using System;

public class DifferenceOfTwoNumbers
{
    public static void Main ()
    {
        int num1;
        int num2;

        Console.Write( "First number: " );
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write( "Second number: " );
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write( "The difference is: " );
        Console.WriteLine( num1-num2 );
    }
}
