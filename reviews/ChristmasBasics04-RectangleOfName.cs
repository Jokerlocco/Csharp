/*
Crea un programa que pida al usuario su nombre y escriba un rectángulo que 
tenga 4 filas de altura y 4 nombres de anchura, así:

Dime tu nombre: Nacho
NachoNachoNachoNacho
Nacho          Nacho
Nacho          Nacho
NachoNachoNachoNacho
*/

// Manuel Lago

using System;

public class RectanguloNombre
{
    public static void Main()
    {
        Console.Write("Dime tu nombre: ");
        string nombre = Console.ReadLine();
        
        for ( int i = 0 ; i < 4 ; i++ )
        {
            Console.Write(nombre);
        }
        Console.WriteLine();
        for ( int i = 0 ; i < 2 ; i++ )
        {
            Console.Write(nombre);
            for ( int j = 0; j < nombre.Length * 2 ; j++ )
            {
                Console.Write(" ");
            }
            Console.Write(nombre);
            Console.WriteLine();
        }
        
        for ( int i = 0 ; i < 4 ; i++ )
        {
            Console.Write(nombre);
        }
    }
}
