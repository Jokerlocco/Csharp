/*
Crea un programa que pida al usuario 5 marcas, modelos y potencias de coches, 
que se deberán guardar en un array de struct. Después mostrará la marca, modelo 
y potencia del coche más potente.
*/

// Versión sin ordenacion, buscando directamente el máximo

using System;

public class Coches
{
    struct Coche
    {
        public string marca;
        public string modelo;
        public int potencia;
    }
    
    public static void Main()
    {
        const int TAMANYO = 5;
        
        Coche[] coches = new Coche[TAMANYO];
        
        for ( int i = 0 ; i < TAMANYO ; i++ )
        {
            Console.Write("Introduce la marca del coche {0}: ",
                i + 1);
            coches[i].marca = Console.ReadLine();
            
            Console.Write("Introduce el modelo del coche {0}: ",
                i + 1);
            coches[i].modelo = Console.ReadLine();
            
            Console.Write("Introduce la potencia del coche {0}: ",
                i + 1);
            coches[i].potencia = Convert.ToInt32(Console.ReadLine());
        }
        
        int posMax = 0;
        
        for ( int i = 1 ; i < TAMANYO - 1 ; i++ )
            if ( coches[i].potencia > coches[posMax].potencia )
                posMax = i;
        
        Console.WriteLine("El coche más potente es: ");
        Console.WriteLine("Marca: " + coches[posMax].marca);
        Console.WriteLine("Modelo: " + coches[posMax].modelo);
        Console.WriteLine("Potencia: " + coches[posMax].potencia);
    }
}
