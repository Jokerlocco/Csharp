// Divide if not zero (1)
// Ruth Martínez

using System;

public class DivideIfNotZero1
{
    public static void Main()
    {
        int x, y;
        Console.Write("Enter first number: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        y = Convert.ToInt32(Console.ReadLine());

        if (y == 0 )
            Console.Write("I cannot divide by zero");
        else
            Console.Write("The division is: {0}", x/y);
    }
}
