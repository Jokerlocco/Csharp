//Sergio Ruescas

/*
Input sample
3
10
41
0

Output
IZQUIERDA
DERECHA
IZQUIERDA
*/

using System;

public class Calle
{
        public static void Main()
        {
            int numero;
            numero = Convert.ToInt32( Console.ReadLine() );

            while (numero != 0)
            {
                if (numero % 2 == 0)
                    Console.WriteLine("DERECHA");
                else 
                    Console.WriteLine("IZQUIERDA");                
                numero = Convert.ToInt32( Console.ReadLine() );
            } 
        }
}
