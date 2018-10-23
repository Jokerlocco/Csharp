//Sergio Ruescas
using System;

public class Canicas
{
    public static void Main()
    {
        int casos, altura, suma;
        casos = Convert.ToInt32( Console.ReadLine() );
        for (int i = 0; i < casos ; i++)
        {
            suma = 0;
            altura = Convert.ToInt32( Console.ReadLine() );
            for (int z = 1; z <= altura ; z++)
            {
                for (int j = 1; j <= z ; j++)
                {
                    suma += j;
                }
            }
            Console.WriteLine(suma);
        }
    }
}

