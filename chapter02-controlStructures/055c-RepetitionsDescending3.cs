// Repetitions descending
// V3: Second loop increasing in one unit

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
            for (int j = 1; j <= 4; j++)
                Console.Write("{0} ", 10 - j*2);
            Console.WriteLine();
        }
    }
}
