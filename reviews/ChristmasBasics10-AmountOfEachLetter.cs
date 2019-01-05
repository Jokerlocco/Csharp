/*
Crea un programa que pida una palabra (o una frase) y diga qué letras contiene 
y en qué cantidad, así:

Escribe una palabra o frase: palabra
a: 3
b: 1
l: 1
p: 1
r: 1
*/

// Manuel Lago

using System;

public class CantidadLetras
{
    public static void Main()
    {
        Console.Write("Escribe una palabra o frase: ");
        string cadena = Console.ReadLine().ToLower();
        
        char[] letras = 
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n'
            ,'ñ','o','p','q','r','s','t','u','v','w','x','y','z'
        };
        
        int[] cantidadLetras = new int [27];
        
        for ( int i = 0 ; i < letras.Length ; i++ )
        {
            for ( int j = 0 ; j < cadena.Length ; j++ )
            {
                if ( cadena[j] == letras[i] )
                    cantidadLetras[i]++;
            }
        }
        
        for ( int i = 0 ; i < letras.Length ; i++ )
        {
            if ( cantidadLetras[i] > 0 )
            {
                Console.WriteLine( letras[i] + ": " + cantidadLetras[i]);
            }
        }
    }
}
