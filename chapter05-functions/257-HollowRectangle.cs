// HollowRectangle
// Manuel Lago

using System;

public class HollowRectangle
{
    public static void DrawHollowRectangle ( int width, int height, 
        char symbol )
    {
        for ( int i = 0 ; i < width ; i++ )
        {
            Console.Write( symbol );
        }
        Console.WriteLine();
        
        for ( int i = 0 ; i < height - 2 ; i++ )
        {
            Console.Write(symbol);
            for ( int j = 0 ; j < width - 2 ; j++ )
            {
                Console.Write(" ");
            }
            Console.Write(symbol);
            Console.WriteLine();
        }
        
        for ( int i = 0 ; i < width ; i++ )
        {
            Console.Write( symbol );
        }
    }
    
    public static void Main()
    {
        Console.Write("Enter the width: ");
        int width = Convert.ToInt32( Console.ReadLine());
        
        Console.Write("Enter the height: ");
        int height = Convert.ToInt32( Console.ReadLine());
        
¡       Console.Write("Enter the symbol: ");
        char symbol = Convert.ToChar( Console.ReadLine());
        
        DrawHollowRectangle( width, height, symbol );
    }
}
