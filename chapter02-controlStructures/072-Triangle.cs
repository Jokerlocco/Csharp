//Jaime Francisco Rebollo Domínguez

using System;

public class Triangle
{
    public static void Main()
    {
        int size;
        
        Console.Write("Enter the size: ");
        size = Convert.ToInt32( Console.ReadLine() );
        
        for (int row = 1; row <= size; row++)
        {
            for (int columns = 1; columns <= row; columns++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}
