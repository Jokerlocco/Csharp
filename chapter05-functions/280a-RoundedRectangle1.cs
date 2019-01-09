using System;

public class RoundedRectangle
{
    
    public static void DisplayRoundedRectangle(int w, int h)
    {
        // First row
        Console.Write("/");
        for (int column = 0; column < w - 2; column++)
        {
            Console.Write("-");
        }
        Console.WriteLine("\\");
        
        // Middle rows
        for(int row = 0; row < h-2; row++)
        {
            Console.Write("|");
            for (int column = 0; column < w - 2; column++)
            {
                Console.Write(" ");
            }
            
            Console.WriteLine("|");
        }
        
        // Last row
        Console.Write("\\");
        for (int column = 0; column < w - 2; column++)
        {
            Console.Write("-");
        }
        Console.WriteLine("/");

        
    }
    
    public static void Main()
    {
        DisplayRoundedRectangle(8,3);
    }
}
