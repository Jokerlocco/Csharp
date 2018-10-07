// José Vicente Antón Castelló
// The buffer

/*
How many men can use wall-mounted urinals at the same time without breaking
the rule that one must always leave a buffer between a urinal and other
urinal?
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

public class Reto0104
{
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cases; i++)
        {
            int urinal = Convert.ToInt32(Console.ReadLine());
            int men = urinal % 2 == 0 ? urinal / 2 : urinal / 2 + 1;
            Console.WriteLine(men);
        }
    }
}
