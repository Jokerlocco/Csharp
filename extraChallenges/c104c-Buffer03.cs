// Jorge Calzada Asenjo
// Challenge 1.04 - The Buffer
/*
How many men can use wall-mounted urinals at the same time without breaking
the rule that one must always leave a buffer between a urinal and other
urinal.
*/

/*
Example of entry:
5
1
2
3
4
5

Output for that example:
1
1
2
2
3
*/

using System;

public class Buffer1
{
    public static void Main()
    {
        int cases;

        cases = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < cases; i++)
        {
            int numberUrinals, result;

            numberUrinals = Convert.ToInt32(Console.ReadLine());
            result = numberUrinals / 2 + (numberUrinals % 2);
            Console.WriteLine(result);
        }
    }
}
