// Adrián Navarro Gabino
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

public class StreetNumberChallenge
{
    public static void Main()
    {
        int streetNumber;
        
        do
        {
            streetNumber = Convert.ToInt32(Console.ReadLine());
            
            if( (streetNumber != 0) && (streetNumber % 2 == 0) )
                Console.WriteLine("DERECHA");
            else if (streetNumber % 2 == 1)
                Console.WriteLine("IZQUIERDA");
        } while(streetNumber != 0);
    }
}
