// Jorge Calzada Asenjo
// Amount of digits in a positive integer number

using System;

public class HowManyDigits
{
    public static void Main()
    {
        int num, digits = 0;

        Console.Write("Ener a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num > 0)
        {
            num = num / 10;
            digits++;
        }

        Console.WriteLine("Digits: {0}", digits);

    }
}
