// Median
// Ivan Lazcano

/*
Entrada de ejemplo

11
1 2 6 17 18 22 35 46 109 153 200
5
5 3 1 2 8
4
4 5 9 2
0

Salida de ejemplo
44
6
9
*/

using System;

class Ej161
{
    public static void Main()
    {
        int casos = Convert.ToInt32(Console.ReadLine());
        while(casos != 0)
        {
            int[] arr = new int[casos];
            string[] datos = Console.ReadLine().Split();
            for (int i = 0; i < casos; i++)
            {
                arr[i] = Convert.ToInt32((datos[i]));
            }

            for (int i = 0; i < casos-1; i++)
            {
                for (int j = i+1; j < casos; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }
            }

            //for (int i = 0; i < casos; i++)
            //{
               // Console.WriteLine(arr[i]);
            //}

            if(casos % 2 != 0)
                Console.WriteLine(arr[casos/2]*2);
            else
                //Console.WriteLine((arr[casos / 2] + " " + arr[casos / 2 - 1]));
                Console.WriteLine( (arr[casos/2] + arr[casos/2-1]) );

            casos = Convert.ToInt32(Console.ReadLine());
        }
    }
}
