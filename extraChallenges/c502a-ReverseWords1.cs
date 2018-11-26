// Cristina Francés
// Reto 5.02: Reverse words

/*
Sample Input 

3
this is a test
foobar
all your base

Output 
Case #1: test a is this
Case #2: foobar
Case #3: base your all
*/

using System;

public class Palabras
{
    public static void Main()
    {
        byte caso = Convert.ToByte(Console.ReadLine());
        string[] palabras;
        
        for(int i = 0; i < caso; i++)
        {
            string frase = Console.ReadLine(); 
            palabras = frase.Split();
            Console.Write("Case #" + (i + 1) + ": ");
            
            for(int j = palabras.Length - 1; j > 0; j--)
                Console.Write(palabras[j] + " ");
            Console.WriteLine(palabras[0]);
        }
    }
}
