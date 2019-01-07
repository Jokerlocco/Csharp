/*
DrawParallelogram(10, 4, '*'); =>

**********
 *        *
  *        *
   ********** 

*/

// José Vicente Antón Castelló

using System;

class Parallelogram
{
    static void DrawParallelogram(byte width, byte height, char symbol)
    {
        Console.WriteLine(new string (symbol, width));

        string spaces = new string(' ', width - 2);

        for (int i = 1; i < height-1; i++)
        {
            Console.WriteLine(new string (' ', i) + symbol + spaces 
                + symbol);
        }

        Console.WriteLine(new string (' ', height-1) 
            + new string (symbol, width));
    }

    static void Main(string[] args)
    {
        DrawParallelogram(10, 4, '*');
    }
}
