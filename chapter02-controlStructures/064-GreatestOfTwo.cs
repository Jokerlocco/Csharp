//Cristina Francés

using System;

public class Ternario
{
    public static void Main()
    {
        int num1, num2, max;

        Console.Write("Enter a number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        /*
        if (num1 > num2)
            max = num1;
        else
            max = num2;
        */

        max = num1 > num2 ? num1 : num2;

        Console.Write("max = {0}",max);
    }
}

