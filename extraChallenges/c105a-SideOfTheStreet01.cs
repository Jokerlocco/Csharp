// Manuel Lago
// Challenge 1.05: Side of the street

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

public class Lado
{
    public static void Main()
    {
        int numi;
        int numcasos = Convert.ToInt32( Console.ReadLine() );
        
        for ( int i = 1 ; i <= numcasos ; i++ )
        {    
            numi = Convert.ToInt32( Console.ReadLine() );
           
            int lado = numi % 2 == 0 ? 1:0;
            
            if (lado == 1)
                Console.WriteLine("IZQUIERDA");
            else
                Console.WriteLine("DERECHA");
        }
    }
}
