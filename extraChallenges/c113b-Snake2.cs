//Jaime Francisco Rebollo Domínguez

using System;

public class Snake
{
    public static void Main()
    {
        int casos;
        
        casos = Convert.ToInt32( Console.ReadLine() );
        
        for(int casoActual = 1; casoActual <= casos; casoActual++)
        {
            byte lineas, caracteres;
            
            lineas = Convert.ToByte( Console.ReadLine() );
            caracteres = Convert.ToByte( Console.ReadLine() );
            
            Console.WriteLine("Caso {0}", casoActual);
            
            for(int i = 1; i <= lineas; i++)
            {
                if(i % 4 == 0)
                {
                    Console.Write("#");
                    for(int j = 0; j < caracteres-1; j++)
                        Console.Write(".");
                } else if (i % 2 == 0)
                {
                    for(int j = 0; j < caracteres-1; j++)
                        Console.Write(".");
                    Console.Write("#");
                } else
                {
                    for(int j = 0; j < caracteres; j++)
                        Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
