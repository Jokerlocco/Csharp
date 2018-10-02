// Repetitions descending
// V1: Normal version

using System;

public class Repetitions
{
    public static void Main()
    {
        int steps;
        Console.Write("How many steps? ");
        steps = Convert.ToInt32( Console.ReadLine() );

        for (int i = 0; i < steps; i++)
        {
            for (int j = 8; j >= 2; j = j-2)
                Console.Write("{0} ", j);
            Console.WriteLine();
        }
    }
}
