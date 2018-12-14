/*
https://www.aceptaelreto.com/problem/statement.php?id=433
Racimos de uvas

Entrada de ejemplo
10
40
400
4000
40000
400000
0

Salida de ejemplo
4
9
28
89
283
894
*/

// Jorge Calzada Asenjo

using System;

public class PerfectGrapeBunch
{
    public static void Main()
    {
        int numberGrapes;

        numberGrapes = Convert.ToInt32(Console.ReadLine());

        while (numberGrapes != 0)
        {
            int count = 0;

            while (numberGrapes > 0)
            {
                count++;
                numberGrapes -= count;
            }

            Console.WriteLine(count);
            // Console.WriteLine(numberGrapes * (numberGrapes - 1) / 2);

            numberGrapes = Convert.ToInt32(Console.ReadLine());
        }
    }
}
