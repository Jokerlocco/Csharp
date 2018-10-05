// Galaxian Console

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 004, 04-Oct-18   J.Rebollo, I.Lazcano: Enemy moves to the right
// 003, 27-Sep-18   J.V.Anton, ???: Console.ReadKey
// 002, 27-Sep-18   K.Marín A.Navarro: Moving the spaceship (4, 6, 0)
// 001, 26-Sep-18   Nacho: Positioning on screen, changing colors


using System;

public class GalaxianConsole
{
    public static void Main()
    {
        int xShip = 40;
        int xEnemy = 40;
        ConsoleKeyInfo key;
        
        do
        {
            // Draw elements
            Console.Clear();
            Console.SetCursorPosition(xEnemy, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("W");
            
            Console.SetCursorPosition(xShip, 22);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("A");
            
            // Process user input
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.LeftArrow)
                xShip = xShip - 3;
            if (key.Key == ConsoleKey.RightArrow)
                xShip = xShip + 3;
            
            // Update world
            xEnemy++;
            
            // Check game status
            // (Not yet)
            
            // Pause until next frame
            // (Not yet)
        }
        while (key.Key != ConsoleKey.Escape);
    }
}
