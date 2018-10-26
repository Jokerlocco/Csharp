// José Vicente Antón Castelló

using System;

public class Trapezoid
{
    public static void Main()
    {
        Console.Write("Enter the width: ");
        byte width = Convert.ToByte(Console.ReadLine());
        Console.Write("Enter the height: ");
        byte height = Convert.ToByte(Console.ReadLine());

        int spaces = height - 1, asterisks = width;

        for (byte i = 0; i < height; i++)
        {
            for (byte j = 0; j < spaces; j++)
                Console.Write(" ");
            for (byte j = 0; j < asterisks; j++)
                Console.Write("*");
            spaces--;
            asterisks += 2;
            Console.WriteLine();
        }
    }
}
