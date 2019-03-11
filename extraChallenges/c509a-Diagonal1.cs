// José Vicente Antón Castelló

/*
nput
5
RUURU
output
3
 
input
17
UUURRRRRUUURURUUU
output
13
*/

using System;

class DiagonalWalking
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        string cadena = Console.ReadLine();

        while (cadena.Contains("RU")
           || cadena.Contains("UR"))
        {
            cadena = cadena.Replace("RU", "D");
            cadena = cadena.Replace("UR", "D");
        }

        Console.WriteLine(cadena.Length);
    }
}
