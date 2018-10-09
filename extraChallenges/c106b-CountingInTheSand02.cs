// Challenge 1.06 - Counting in the sand (acepta 369)

/*
Counting in base 1

Example input
1
4
6
0

Example output
1
1111
111111
*/

using System;

public class Sand2
{
    public static void Main()
    {
        int amount = Convert.ToInt32(Console.ReadLine());
        
        while(amount != 0)
        {
            for (int i = 0; i < amount; i++)
                Console.Write("1");
            Console.WriteLine();

            amount = Convert.ToInt32(Console.ReadLine());
        }
    }
}
