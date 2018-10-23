//Cristina Francés
//Reto 1.12 - Pirámide de canicas

using System;

public class Canicas
{
    public static void Main()
    {
        int cantidad = Convert.ToInt32(Console.ReadLine());
        int contador = 0;
        
            for ( int i = 1; i <= cantidad; i++ )
            {
                    int total = Convert.ToInt32(Console.ReadLine());
                    contador = total*(total+1)*(total+2)/6;
                    Console.WriteLine(contador);
            }
    }
}
 
