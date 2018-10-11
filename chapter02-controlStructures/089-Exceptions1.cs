using System;

public class Exceptions1
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32( Console.ReadLine() );
            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine( "The product is {0}", a * b );
        }
        catch (FormatException)
        {
            Console.WriteLine("That is not a valid number!");
        }
    }
}
