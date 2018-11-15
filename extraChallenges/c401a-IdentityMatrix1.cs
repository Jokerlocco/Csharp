// Jorge Calzada Asenjo

using System;

public class MatrizIdentidad
{
    public static void Main()
    {
        int dimensiones;

        dimensiones = Convert.ToInt32(Console.ReadLine());

        while (dimensiones != 0)
        {
            int[,] matriz = new int[dimensiones, dimensiones];

            for (int fila = 0; fila < dimensiones; fila++)
            {
                string[] numbersString = Console.ReadLine().Split();
                for (int columna = 0; columna < dimensiones; columna++)
                {
                    matriz[fila, columna] = Convert.ToInt32(numbersString[columna]);
                }
            }

            bool matrizIdentidad = true;

            for (int fila = 0; fila < dimensiones; fila++)
            {
                for (int columna = 0; columna < dimensiones; columna++)
                {
                    if ((fila == columna && matriz[fila, columna] != 1) ||
                        (fila != columna && matriz[fila, columna] != 0))
                    {
                        matrizIdentidad = false;
                    }
                }
            }

            if (matrizIdentidad)
            {
                Console.WriteLine("SI");
            }
            else
            {
                Console.WriteLine("NO");
            }

            dimensiones = Convert.ToInt32(Console.ReadLine());
        }
    }
}
