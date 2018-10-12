// Hollow Rectangle 2

using System;

public class HollowRectangle2
{
    public static void Main()
    {
        Console.Write("Width? ");
        int width = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Height? ");
        int height = Convert.ToInt32(Console.ReadLine());
        
        // First row
        for(int column = 0; column < width; column++)
            Console.Write("*");
        Console.WriteLine();
        
        // Middle rows
        for (int row = 0; row < height-2; row++)
        {
            Console.Write("*");
            for (int space = 0; space < width - 2; space++)
                Console.Write(" ");
            Console.Write("*");
            Console.WriteLine();
        }
        
        // Last row
        for(int column = 0; column < width; column++)
            Console.Write("*");
        Console.WriteLine();
        
        
    }
}
        
