// Jorge Calzada

using System;

class TresEnRaya3
{
    static void Main()
    {
        char[,] tablero = new char[3, 3];

        int posX, posY;

        bool firstPlayer = true;

        bool finJuego = false;
        string resultado = "";

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tablero[i, j] = '·';
            }
        }

        Console.Clear();

        Console.WriteLine("    TRES EN RAYA    ");
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tablero[i, j] + "        ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        do
        {
            // Pedir datos
            do
            {
                do
                {
                    Console.Write("Turno de las {0}. Introduce fila (1 - 3): ",
                        firstPlayer ? "O" : "X");
                    try
                    {
                        posY = Convert.ToInt32(Console.ReadLine()) - 1;
                    }
                    catch (Exception)
                    {
                        posY = -1;
                    }

                    if (posY > 2 || posY < 0)
                    {
                        Console.WriteLine("Posición no válida.");
                    }
                }
                while (posY > 2 || posY < 0);


                do
                {
                    Console.Write("Turno de las {0}. Introduce columna (1 - 3): ",
                        firstPlayer ? "O" : "X");
                    try
                    {
                        posX = Convert.ToInt32(Console.ReadLine()) - 1;
                    }
                    catch (Exception)
                    {
                        posX = -1;
                    }

                    if (posX > 2 || posX < 0)
                    {
                        Console.WriteLine("Posición no válida.");
                    }
                }
                while (posX > 2 || posX < 0);

                if (tablero[posY, posX] != '·')
                {
                    Console.WriteLine();
                    Console.WriteLine("Error. Celda ocupada.");
                }
            }
            while (tablero[posY, posX] != '·');

            tablero[posY, posX] = firstPlayer ? 'O' : 'X';

            firstPlayer = !firstPlayer;


            // Dibujar tablero
            Console.Clear();

            Console.WriteLine("    TRES EN RAYA    ");
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tablero[i, j] + "        ");
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }


            //Comprobar juego
            finJuego = true;

            char caracterActual = !firstPlayer ? 'O' : 'X';

            bool comprobacionFilas = false;
            bool comprobacionColumnas = false;
            bool comprobacionDiagonal = false;

            if ((tablero[0, 0] == caracterActual &&
                tablero[1, 1] == caracterActual &&
                tablero[2, 2] == caracterActual) ||
                (tablero[0, 2] == caracterActual &&
                tablero[1, 1] == caracterActual &&
                tablero[2, 0] == caracterActual))
            {
                comprobacionDiagonal = true;
            }

            int iComprobacion = 0;
            while (iComprobacion < 3 && (!comprobacionFilas &&
                !comprobacionColumnas && !comprobacionDiagonal))
            {
                comprobacionFilas = true;
                comprobacionColumnas = true;

                for (int j = 0; j < 3; j++)
                {
                    if (tablero[iComprobacion, j] != caracterActual)
                    {
                        comprobacionFilas = false;
                    }

                    if (tablero[j, iComprobacion] != caracterActual)
                    {
                        comprobacionColumnas = false;
                    }
                }
                iComprobacion++;
            }

            if (!comprobacionFilas && !comprobacionColumnas &&
                !comprobacionDiagonal)
            {
                foreach (char c in tablero)
                {
                    if (c == '·')
                    {
                        finJuego = false;
                    }
                    else
                    {
                        resultado = "Empate";
                    }
                }
            }
            else
            {
                resultado = "Ganan las " + (!firstPlayer ? 'O' : 'X');
            }

        } while (!finJuego);

        Console.WriteLine("FIN DEL JUEGO");
        Console.WriteLine(resultado);
    }
}
