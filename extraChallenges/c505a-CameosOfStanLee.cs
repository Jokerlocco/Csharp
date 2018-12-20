// https://www.aceptaelreto.com/problem/statement.php?id=475
// Cameos de Stan Lee
// Cantidad de veces que aparece "stan lee" en cada frase
// Nacho, 19-Dic-2018

/*
Entrada de ejemplo

12
Que me diga donde estan, le exijo!
Eres tan lento que te ganaria una oruga. Calla y salta, no le temas.
Esto es canela, verdad que si?
Stan Stan Lee Lee
Stan Loo
St anlEe
St an lEe
stanle
stanley
stanlye
tsanlee
stanleestanlee

Salida de ejemplo
 
1
2
1
1
0
1
1
0
0
0
0
0
2

*/

using System;

class CameosOfStanLee
{
    static void Main()
    {

        int casos;
        string frase;
        string busqueda = "stanlee";
        int cantidadLetras = busqueda.Length;

        casos = Convert.ToInt32(Console.ReadLine());

        for (int c = 0; c < casos; c++)
        {
            int apariciones = 0;
            int letraActual = 0;

            frase = Console.ReadLine();
            for (int i = 0; i < frase.Length; i++)
            {
                if (Char.ToLower(frase[i]) == busqueda[letraActual])
                {
                    letraActual++;
                    if (letraActual == cantidadLetras)
                    {
                        apariciones++;
                        letraActual = 0;
                    }
                }
            }

            Console.WriteLine(apariciones);
        }
    }
}
