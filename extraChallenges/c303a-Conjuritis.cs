/*
// https://www.aceptaelreto.com/problem/statement.php?id=478
// Conjuritis
// Dos conjuros no funcionan; el resto suman n
// Nacho, 19-Dic-2018
// Nota: solución lenta, muestra una posible solución pero da TLE en Acepta
 
Entrada de ejemplo

3
1 2 3
3
4
1 3 5 9
10
5
1 3 5 6 7
18
0

Salida de ejemplo

1 2
3 5
1 3

*/

using System;

class Conjuritis
{
    static void Main()
    {
        long conjuros;
        long suma, total, sobra;
        long ultima, i, j;

        conjuros = Convert.ToInt64(Console.ReadLine());
        while (conjuros != 0)
        {
            // Leemos datos
            long[]datos = new long[conjuros];
            suma = 0;
            string[] detalles = Console.ReadLine().Split();
            for (i = 0; i < conjuros; i++)
            {
                datos[i] = Convert.ToInt64(detalles[i]);
                suma += datos[i];
            }
            total = Convert.ToInt64(Console.ReadLine());

            // Calculamos lo que sobra
            sobra = suma - total;

            // Y la última posición válida para comparar
            ultima = conjuros - 1;
            while (datos[ultima] > sobra)
                ultima--;

            // Y después ya probamos combinaciones
            for (i = 0; i < ultima; i++)
            {
                for (j = ultima; j > i; j--)
                    if (datos[i] + datos[j] == sobra)
                    {
                        Console.WriteLine(datos[i] + " " + datos[j]);
                        goto siguiente;
                    }

            }

        siguiente:
            conjuros = Convert.ToInt64(Console.ReadLine());
        }
    }
}
