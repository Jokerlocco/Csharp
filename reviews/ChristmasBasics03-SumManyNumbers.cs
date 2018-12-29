/*
Crea un programa que pregunte cuántos números va a sumar y le pida esa serie de 
números, para, a continuación, mostrar el resultado de la suma. Si se introduce 
una cantidad negativa o cero, se deberá volver a introducir tantas veces como 
sea necesario. Finalmente, se mostrarán todos los datos. Ejemplo:

Cantidad de sumandos? -2
Cantidad incorrecta
Cantidad de sumandos? 3
Sumando 1? 2
Sumando 2? -5
Sumando 3? 10,5
Su suma es 7,5
Los datos eran 2 -5 10,5
*/

// Manuel Lago

using System;

public class Sumandos
{
    public static void Main()
    {
        int cantidad;
        
        do
        {
            Console.Write("Cantidad de sumandos? ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            
            if ( cantidad < 1 )
            {
                Console.WriteLine("Cantidad Incorrecta");
            }
            
        }while ( cantidad < 1 );
        
        double[] sumandos = new double[cantidad];
        double total = 0;
        
        for ( int i = 0; i < cantidad ; i++ )
        {
            Console.Write("¿Sumando {0}?: ", i + 1);
            sumandos[i] = Convert.ToDouble(Console.ReadLine());
            
            total += sumandos[i];
        }
        
        Console.WriteLine("La suma es " + total);
        Console.Write("Los datos eran ");
        
        foreach ( double d in sumandos )
        {
            Console.Write(d + " ");
        }
        
    }
}
