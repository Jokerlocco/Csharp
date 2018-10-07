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


import java.util.*;

public class StreetNumberChallenge
{
    public static void main(String[] args)
    {
        int streetNumber;
        
        Scanner entrada = new Scanner(System.in);
        
        do
        {
            streetNumber = entrada.nextInt();
            
            if( (streetNumber != 0) && (streetNumber % 2 == 0) )
                System.out.println("DERECHA");
            else if (streetNumber % 2 == 1)
                System.out.println("IZQUIERDA");
        } while(streetNumber != 0);
    }
}
