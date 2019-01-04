/*
Crea una función "ExtraerVocales", que reciba una cadena y devuelva un array de 
caracteres. Este array contendrá las vocales que había en esa cadena. Por 
ejemplo, para "Hooola" devolvería un array que contendría 'o','o','o', 'a'

Crea una función "ExtraerVocalesNR", que reciba una cadena y devuelva una 
cadena formada por las vocales que contiene, sin repetir, en minúsculas y 
ordenadas alfabéticamente.Por ejemplo, para "Que Tal Estas?" devolvería la 
cadena “aeu”
 
Crea un Main que permita probar ambas (usando "foreach" en el caso del array de 
caracteres).
*/

// Manuel Lago, simplificado por Nacho

using System;

public class Vocales
{
    public static char[] ExtraerVocales ( string cadena )
    {
        string respuesta = "";
        
        for ( int i = 0 ; i < cadena.Length ; i++ )
        {
            if (( cadena[i] == 'a' ) ||
                ( cadena[i] == 'A' ) ||
                ( cadena[i] == 'e' ) ||
                ( cadena[i] == 'E' ) ||
                ( cadena[i] == 'i' ) ||
                ( cadena[i] == 'I' ) ||
                ( cadena[i] == 'o' ) ||
                ( cadena[i] == 'O' ) ||
                ( cadena[i] == 'u' ) ||
                ( cadena[i] == 'U' ) )
            {
                respuesta += cadena[i];
            }
        }
        
        // Se podría crear un array de la longitud de la cadena,
        // y volcar su contenido letra a letra... o bien usar ToCharArray
        return respuesta.ToCharArray();
    }
    
    public static string ExtraerVocalesNR ( string cadena )
    {
        string respuesta = "";
        cadena = cadena.ToUpper();
        if (cadena.Contains("A")) respuesta += "a";
        if (cadena.Contains("E")) respuesta += "e";
        if (cadena.Contains("I")) respuesta += "i";
        if (cadena.Contains("O")) respuesta += "o";
        if (cadena.Contains("U")) respuesta += "u";
        return respuesta;
    }
    
    public static void Main()
    {
        Console.WriteLine("Introduce una cadena: ");
        string cadena = Console.ReadLine();
        
        foreach ( char c in ExtraerVocales(cadena))
        {
            Console.Write(c + " ");
        }
        
        Console.WriteLine();
        Console.WriteLine(ExtraerVocalesNR(cadena));
    }
}
