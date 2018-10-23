// Jorge Calzada Asenjo
// Challenge 1.12: Pyramid of marbles
// C# version

/*
To calculate how many marbles form a pyramid with triangular base knowing
the height of the pyramid.

Type 1
This type uses a loop and several variables to calculate the number of marbles.
*/

/*
Example of input
6
1
2
3
4
5
6

Example of output
1
4
10
20
35
56
*/

using System;

public class Pyramid1a
{
    public static void Main()
    {
        int cases;
        ulong height;

        cases = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cases; i++)
        {
            height = Convert.ToUInt64(Console.ReadLine());
            ulong totalLine = 0, totalLayer = 0, totalPyramid = 0;

            for (ulong j = 1; j <= height; j++)
            {
                totalLine++;
                totalLayer += totalLine;
                totalPyramid += totalLayer;
            }

            Console.WriteLine(totalPyramid);
        }
    }
}
