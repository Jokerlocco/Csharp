// Galaxian Console

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 001, 26-Sep-18   Nacho: Positioning on screen, changing colors
// 002, 27-Sep-18   K.Marín A.Navarro: Moving the spaceship (4, 6, 0)

using System;

public class GalaxianConsole
{
    public static void Main()
    {
        int x = 40;
        int key;
        
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
            key = Convert.ToInt32(Console.ReadLine());
            if( key == 4 )
                x = x - 3;
            if( key == 6 )
                x = x + 3;
            
            // Update world
            // (Not yet)
            
            // Check game status
            // (Not yet)
            
            // Pause until next frame
            // (Not yet)
        }
        while( key != 0 );
    }
}
