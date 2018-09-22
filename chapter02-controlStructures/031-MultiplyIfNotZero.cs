// Manuel Rojas Henarejos
// Multiply if not zero

using System;

public class MultiplyIzNotZero

{
    public static void Main()
    {
        int num1, num2;

        Console.Write("Enter a number: ");
        num1=Convert.ToInt32(Console.ReadLine());

        if (num1 == 0)
            Console.Write("0 times anything is always 0");
        else
        {
            Console.Write("Enter another number: ");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.Write("The product is {0}", num1*num2);
        }
    }
}
