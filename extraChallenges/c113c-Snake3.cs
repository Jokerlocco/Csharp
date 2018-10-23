//Kevin Marín Romero

using System;

public class Snake
{
    public static void Main()
    {
        byte cases, i, M, N, height, stripe, points;
        bool side;
        
        cases = Convert.ToByte(Console.ReadLine());
        
        for ( i = 1; i <= cases; i++)
        {
            M = Convert.ToByte(Console.ReadLine());
            N = Convert.ToByte(Console.ReadLine());
            
            Console.WriteLine("Caso {0}", i);
            side = true;
            
            for (height = 1; height <= M; height++)
            {
                if (height % 2 != 0)
                {
                    for (stripe = 0; stripe < N; stripe++)
                        Console.Write("#");
                    Console.WriteLine();
                }
                else
                {
                    for (points = 1; points <= N; points++)
                    {
                        if (side)
                            if (points <= (N-1))
                                Console.Write(".");
                            else
                            {
                                Console.Write("#");
                                side = false;
                            }
                        else
                            if (points == 1)
                                Console.Write("#");
                            else if (points == N)
                            {
                                Console.Write(".");
                                side = true;
                            }
                            else
                                Console.Write(".");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
