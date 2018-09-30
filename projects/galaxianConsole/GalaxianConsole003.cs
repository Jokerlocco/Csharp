// Galaxian Console

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 003, 27-Sep-18   J.V.Anton, ???: Console.ReadKey
// 002, 27-Sep-18   K.Marín A.Navarro: Moving the spaceship (4, 6, 0)
// 001, 26-Sep-18   Nacho: Positioning on screen, changing colors


using System;

public class GalaxianConsole
{
    public static void Main()
    {
        int x = 40;
        ConsoleKeyInfo key;
        
        do
        {
            // Draw elements
            Console.Clear();
            Console.SetCursorPosition(40, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("W");
            
            Console.SetCursorPosition(x, 22);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("A");
            
            // Process user input
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.LeftArrow)
                x = x - 3;
            if (key.Key == ConsoleKey.RightArrow)
                x = x + 3;
            
            // Update world
            // (Not yet)
            
            // Check game status
            // (Not yet)
            
            // Pause until next frame
            // (Not yet)
        }
        while (key.Key != ConsoleKey.Escape);
    }
}
