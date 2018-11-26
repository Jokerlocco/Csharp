// Reto 5.03 (acepta 188)
// Ivan Lazcano

/*
Entrada de ejemplo

gugutata
mata tapa papa pato
seto taco coma matute
sien encima mapa patuco comida
cata tasama malote tejaba batama
kiosko comida

Salida de ejemplo

SI
SI
NO
SI
SI
NO
*/

using System;

public class I
{
    public static void Main()
    {
        string[] word = Console.ReadLine().Split();
        while (word[0] != "")
        {
            
            if (word.Length == 1)
                Console.WriteLine("SI");
            else
            {
                bool correct = true;
                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (word[i][word[i].Length - 2] != word[i + 1][0] ||
                       word[i][word[i].Length - 1] != word[i + 1][1])
                        correct = false;
                }
                if (correct)
                    Console.WriteLine("SI");
                else
                    Console.WriteLine("NO");
                
            }
            word = Console.ReadLine().Split();
        }
    }
}
