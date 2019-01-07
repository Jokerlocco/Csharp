/*
DrawParallelogram(10, 4, '*'); =>

**********
 *        *
  *        *
   ********** 

*/

// Araceli Yáñez Muñoz

using System;

class Parallelogram
{
    static void DrawParallelogram(int width, int height, char symbol)
    {
        for(int i = 0; i < height; i++)
        {
            if (i == 0)
            {
                for(int j = 0; j < width; j++)
                    Console.Write(symbol);
                Console.WriteLine();
            }
            else if(i == height-1)
            {
                for(int j = 0; j < i; j++)
                    Console.Write(" ");
                for (int j = 0; j < width; j++)
                    Console.Write(symbol);
                Console.WriteLine();
            }
            else
            {
                for (int j = 0; j < i; j++)
                    Console.Write(" ");
                Console.Write("*");
                for (int j = 0; j < width-2; j++)
                    Console.Write(" ");
                Console.Write("*");
                Console.WriteLine();
            }
        }
    }
    static void Main()
    {
        DrawParallelogram(10, 4, '*');
    }
}
