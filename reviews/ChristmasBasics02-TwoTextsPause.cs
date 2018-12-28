/*
Crea un programa que pregunte al usuario dos palabras y cuántas veces líneas se 
deben mostrar en pantalla alternándolas. Deberá escribir ambos palabras varias 
veces, cada una en una línea, hasta llegar al total indicado por el usuario. 
Por ejemplo:

Dime una palabra: DAM
Dime otra palabra: 2018
Cuantas líneas totales quieres? 3
DAM
2018
DAM

Tras cada 20 líneas, deberá hacerse una pausa (esperar hasta que el usuario 
pulse Intro) 
*/

// Manuel Lago

using System;

public class RepetirNombresLineas
{
    public static void Main()
    {
        Console.Write("Dime una palabra: ");
        string palabraUno = Console.ReadLine();
        
        Console.Write("Dime otra palabra: ");
        string palabraDos = Console.ReadLine();
        
        Console.Write("Cuantas líneas totales quieres? ");
        int lineas = Convert.ToInt32(Console.ReadLine());
        
        int countVeces = 1;
        
        for ( int i = 1 ; i <= lineas ; i++ )
        {
            if ( i % 2 == 0 )
            {
                Console.Write(palabraDos);
            }
            else
            {
                Console.Write(palabraUno);
            }
            
            countVeces++;
            
            if ( countVeces == 20 )
            {
                Console.ReadLine();
                countVeces = 1;
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
