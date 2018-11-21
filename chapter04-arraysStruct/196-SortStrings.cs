using System;

public class OrdenarCadenas
{
    public static void Main()
    {
        
        const int SIZE = 5;
        string aux;
        
        string[] datos = new string [SIZE];
        
        for ( int i = 0 ; i < SIZE ; i++ )
        {
           Console.Write("Introduce la palabra {0}: ", i + 1);
           datos[i] = Console.ReadLine();
        }
        
        for ( int i = 0 ; i < SIZE - 1 ; i++ )
        {
            for ( int j = i + 1 ; j < SIZE ; j++ )
            {
                if (datos[i].CompareTo(datos[j]) > 0 )
                {
                    aux = datos[i];
                    datos[i] = datos[j];
                    datos[j] = aux;
                }
            }
        }
        
        for ( int i = 0 ; i < SIZE ; i++ )
        {
            Console.Write(datos[i] + " ");
        }
    }
}
