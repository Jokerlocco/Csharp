// Repetitions descending
// V2: Both loops are increasing

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
            for (int j = 2; j <= 8; j = j+2)
                Console.Write("{0} ", 10-j);
            Console.WriteLine();
        }
    }
}
