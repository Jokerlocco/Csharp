/*
// https://www.aceptaelreto.com/problem/statement.php?id=474
// Tu amigable vecino
// Nacho, 19-Dic-2018
 
Entrada de ejemplo
7
100 150 200
300 100 700
500 1000 700
500 1000 700
1000 500 700
1000 700 500
700 1000 500

Salida de ejemplo
 
100
800
500
500
500
500
700

*/

using System;

class YourFriendlyNeighbour
{
    static void Main(string[] args)
    {
        long casos;
        long origen, destino1, destino2;
        long distancia1a, distancia1b, suma1,
            distancia2a, distancia2b, suma2;

        casos = Convert.ToInt64(Console.ReadLine());

        for (long i = 0; i < casos; i++)
        {
            string[] detalles = Console.ReadLine().Split();
            origen = Convert.ToInt32(detalles[0]);
            destino1 = Convert.ToInt32(detalles[1]);
            destino2 = Convert.ToInt32(detalles[2]);

            // Primero coste de origen -> 1 -> 2
            distancia1a = Math.Abs(destino1 - origen);
            distancia1b = Math.Abs(destino2 - destino1);
            suma1 = distancia1a + distancia1b;

            // Luego coste de origen -> 2 -> 1
            distancia2a = Math.Abs(destino2 - origen);
            distancia2b = Math.Abs(destino2 - destino1);
            suma2 = distancia2a + distancia2b;

            // Y me quedo con el menor
            if (suma1 < suma2)
                Console.WriteLine(suma1);
            else
                Console.WriteLine(suma2);
        }
    }
}
