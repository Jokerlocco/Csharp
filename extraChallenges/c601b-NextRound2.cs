// Jorge Calzada Asenjo
// Next Round

/*
input 1
8 5
10 9 8 7 7 7 5 5

output 1
6

input 2
4 2
0 0 0 0
output 2
0
*/

using System;

public class NextRound
{
    public static void Main()
    {
        int[] cases = Array.ConvertAll(
            Console.ReadLine().Split(),
            int.Parse);

        int[] scores = Array.ConvertAll(
            Console.ReadLine().Split(),
             int.Parse);

        int i = 0;

        while (i < cases[0] &&
               scores[i] >= scores[cases[1]] &&
               scores[i] > 0)
            i++;

        Console.WriteLine(i);
    }
}
