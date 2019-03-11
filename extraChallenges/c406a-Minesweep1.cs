// José Vicente Antón Castelló

/*

Ejemplo de entrada

4 4
*...
....
.*..
....

Ejemplo de salida

*100
2210
1*10
1110

Ejemplo de entrada

3 5
**...
.....
.*...

Ejemplo de salida

**100
33200
1*100

*/

using System;

class RetoBuscaminas
{
    static int CuentaMinasAlrededor(string[] mapa, int i, int j)
    {
        int minas = 0;

        for (int k = i - 1; k <= i + 1; k++)
        {
            for (int l = j - 1; l <=  j + 1; l++)
            {
                if ((k != i || l != j)
                    && k >= 0 && l >= 0
                    && l < mapa[0].Length
                    && k < mapa.Length
                    && mapa[k][l] == '*')

                    minas++;
            }
        }

        return minas;
    }

    static void Main(string[] args)
    {
        string[] line = Console.ReadLine().Split();

        int m = Convert.ToInt32(line[0] + "");
        int n = Convert.ToInt32(line[1] + "");

        string[] mapa = new string[m];

        for (int i = 0; i < m; i++)
        {
            mapa[i] = Console.ReadLine();
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mapa[i][j] != '*')
                {
                    Console.Write(CuentaMinasAlrededor(mapa, i, j));
                }
                else
                {
                    Console.Write('*');
                }
            }
            Console.WriteLine();
        }
    }
}
