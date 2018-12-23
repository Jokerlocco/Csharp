// https://www.aceptaelreto.com/problem/statement.php?id=479
// El hombre sin miedo y sin radar
// ¿A qué distancia hay enemigos en una cierta dirección?
// Nacho, 23-Dic-2018
// Nota: solución lenta, mejorable con precálculos

/* 
Entrada de ejemplo

3 8
.X....X.
...X....
....X...
3
3 2 ARRIBA
2 1 DERECHA
1 1 ABAJO
0 0

Salida de ejemplo

2
3
NINGUNO
---

*/

using System;

class Daredevil
{
    static void Main()
    {
        byte height, width;
        do
        {
            string[] roomsize = Console.ReadLine().Split();
            height = Convert.ToByte(roomsize[0]);
            width = Convert.ToByte(roomsize[1]);

            if (height != 0 && width != 0)
            {
                // First, let's read the map
                string[] room = new string[height];
                for (int row = 0; row < height; row++)
                {
                    room[row]= Console.ReadLine();
                }

                // Then, the queries
                int queries = Convert.ToInt32(Console.ReadLine());
                for (int q = 0; q < queries; q++)
                {
                    // Let's read and prepare data for each query
                    string[] queryData = Console.ReadLine().Split();
                    byte row = Convert.ToByte(queryData[0]);
                    row--;
                    byte column = Convert.ToByte(queryData[1]) ;
                    column--;
                    string direction = queryData[2];
                    int xIncr = 0, yIncr = 0;
                    switch (direction)
                    {
                        case "IZQUIERDA": xIncr = -1; break;
                        case "DERECHA": xIncr = 1; break;
                        case "ARRIBA": yIncr = -1; break;
                        case "ABAJO": yIncr = 1; break;
                    }
                    // And now, let's search...
                    bool found = false, outOfMap = false;
                    byte steps = 0;
                    do
                    {
                        steps++;
                        row = (byte)(row + yIncr);
                        column = (byte)(column + xIncr);
                        if ((row < 0) || (column < 0) ||
                                (row >= height) || (column >= width))
                        {
                            outOfMap = true;
                            Console.WriteLine("NINGUNO");
                        }
                        else
                        {
                            if (room[row][column] == 'X')
                            {
                                found = true;
                                Console.WriteLine(steps);
                            }
                        }

                    }
                    while (!found && !outOfMap);
                }
                Console.WriteLine("---");
            }
        } while (height != 0 && width != 0);
    }
}
