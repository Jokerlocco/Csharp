/*
Crea un programa que pregunte al usuario su nombre y cuántas veces desea verlo 
escrito. Deberá escribir el nombre tantas veces como haya indicado el usuario, 
cada una en una línea. En las líneas impares, el nombre se mostrará tal cual; 
en las pares se mostrará precedido por fos guiones y seguido por otros dos 
guiones. Por ejemplo:

Dime tu nombre: Juan
Cuantas veces quieres que lo escriba? 3
Juan
--Juan--
Juan
*/

// Manuel Lago

using System;

public class RepetirNombres
{
    public static void Main()
    {
        Console.Write("Dime tu nombre: ");
        string nombre = Console.ReadLine();
        
        Console.Write("Cuantas veces quieres que lo escriba? ");
        int veces = Convert.ToInt32(Console.ReadLine());
        
        for ( int i = 1 ; i <= veces ; i++ )
        {
            if ( i % 2 == 0 )
            {
                Console.Write("--" + nombre + "--");
            }
            else
            {
                Console.Write(nombre);
            }
            Console.WriteLine();
        }
    }
}
