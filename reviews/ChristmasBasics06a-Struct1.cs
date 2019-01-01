/*
Crea un programa que pida al usuario 5 marcas, modelos y potencias de coches, 
que se deberán guardar en un array de struct. Después mostrará la marca, modelo 
y potencia del coche más potente.
*/

// Manuel Lago
// Versión usando ordenación

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
        
        Coche aux;
        
        for ( int i = 0 ; i < TAMANYO - 1 ; i++ )
        {
            for ( int j = i + 1 ; j < TAMANYO ; j++ )
            {
                if ( coches[j].potencia > coches[i].potencia )
                {
                    aux = coches[i];
                    coches[i] = coches[j];
                    coches[j] = coches[i];
                }
            }
        }
        
        Console.WriteLine("El coche más potente es: ");
        Console.WriteLine("Marca: " + coches[0].marca);
        Console.WriteLine("Modelo: " + coches[0].modelo);
        Console.WriteLine("Potencia: " + coches[0].potencia);
    }
}
