// Jorge Calzada

/*
    It should be checked if the distribution of figurines in the courtyard is
    correct taking into account that the figurines can not be at the ends, or
    be close between them.
*/

/*
Example input

6
4 4
XXXX
XXXX
XXXX
XXXX
3 3
XXX
XFX
XXX
3 3
XXX
FXX
XXX
4 3
XXXX
FXFX
XXXX
6 6
XXXXXX
XFXXFX
XXXXXX
XFXFXX
XXXXXX
XXXXXX
3 3
XFX
XXX
XXX

Example output
INVALIDA
VALIDA
INVALIDA
INVALIDA
VALIDA
INVALIDA

*/

using System;

class UntouchableFigurines
{
    static void Main()
    {
        int cases;
        int width, height;
        bool correct;

        cases = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cases; i++)
        {
            correct = false;
            string[] measures = Console.ReadLine().Split();
            int j;

            width = Convert.ToInt32(measures[0]);
            height = Convert.ToInt32(measures[1]);

            string[] patioTiles = new string[height];

            for (j = 0; j < height; j++)
            {
                patioTiles[j] = Console.ReadLine();
            }

            if (patioTiles[0].Contains("F") ||
                patioTiles[height - 1].Contains("F"))
            {
                j = height;
            }
            else
            {
                j = 1;
            }

            while (!correct && j < height - 1)
            {
                if (patioTiles[j].Contains("F"))
                {
                    correct = true;
                }

                j++;
            }

            j = 1;
            while (correct && j < height - 1)
            {
                if (patioTiles[j].StartsWith("F") ||
                    patioTiles[j].EndsWith("F"))
                {
                    correct = false;
                }
                j++;
            }

            j = 1;
            while (correct && j < height - 1)
            {
                int z = 1;
                while (correct && z < width - 1)
                {
                    if (patioTiles[j][z] == 'F')
                    {
                        if (patioTiles[j - 1][z - 1] == 'F' ||
                            patioTiles[j - 1][z] == 'F' ||
                            patioTiles[j - 1][z + 1] == 'F' ||
                            patioTiles[j][z - 1] == 'F' ||
                            patioTiles[j][z + 1] == 'F' || /**/
                            patioTiles[j + 1][z - 1] == 'F' ||
                            patioTiles[j + 1][z] == 'F' ||
                            patioTiles[j + 1][z + 1] == 'F')
                        {
                            correct = false;
                        }
                    }

                    z++;
                }
                j++;
            }

            if (correct)
            {
                Console.WriteLine("VALIDA");
            }
            else
            {
                Console.WriteLine("INVALIDA");
            }
        }
    }
}
