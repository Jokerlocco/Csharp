// José Vicente Antón Castelló

/*
Input sample

3
3
8 8 8
2
5 3
4
3 4 5 6

Output sample

Case #1: 3
Case #2: 1
Case #3: 3
*/


using System;
using System.Collections.Generic;

class RetoPizza
{
    static void Main(string[] args)
    {
        int casos = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < casos; i++)
        {
            int personas = Convert.ToInt32(Console.ReadLine());

            string[] maximosPorPersona = Console.ReadLine().Split();

            int totalPorciones = 0;

            for (int j = 0; j < personas; j++)
            {
                totalPorciones += Convert.ToInt32(maximosPorPersona[j]);
            }

            Console.WriteLine("Case #" + (i + 1) + ": " 
                + (totalPorciones / 8 + (totalPorciones % 8 == 0 ? 0 : 1)));
        }
    }
}
