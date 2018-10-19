// Galaxian Console

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 010, 18-Oct-18   Nacho: "finished" is boolean
// 009, 11-Oct-18   María González Martínez: Two enemies
// 008, 04-Oct-18   Nacho: Slowing down
// 007, 04-Oct-18   Nacho: Simultaneous movement (too fast)
// 006, 04-Oct-18   J.Calzada, JC.Mendoza: Enemy moves to both sides (2: speed)
// 005, 04-Oct-18   S.Ruescas, S.Canovas: Enemy moves to both sides (1: flag)
// 004, 04-Oct-18   J.Rebollo, I.Lazcano: Enemy moves to the right
// 003, 27-Sep-18   J.V.Anton, D.Contreras: Console.ReadKey
// 002, 27-Sep-18   K.Marín A.Navarro: Moving the spaceship (4, 6, 0)
// 001, 26-Sep-18   Nacho: Positioning on screen, changing colors


using System;
using System.Threading;

public class GalaxianConsole
{
    public static void Main()
    {
        int xShip = 40;
        int xEnemy = 40;
        int xEnemy2 = 30;
        ConsoleKeyInfo key;
        int enemySpeed = 2;
        int enemySpeed2 = -3;
        bool finished = false;

        do
        {
            // Draw elements
            Console.Clear();
            Console.SetCursorPosition(xEnemy, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("W");

            Console.SetCursorPosition(xEnemy2, 15);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("W");

            Console.SetCursorPosition(xShip, 22);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("A");

            // Process user input
            if (Console.KeyAvailable)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow)
                    xShip = xShip - 3;
                if (key.Key == ConsoleKey.RightArrow)
                    xShip = xShip + 3;
                if (key.Key == ConsoleKey.Escape)
                    finished = true;
            }
            // Update world
            if ((xEnemy <= 5) || (xEnemy >= 75))
                enemySpeed = -enemySpeed;
            xEnemy = xEnemy + enemySpeed;

            if ((xEnemy2 <= 5) || (xEnemy2 >= 75))
                enemySpeed2 = -enemySpeed2;
            xEnemy2 = xEnemy2 + enemySpeed2;

            // Check game status
            // (Not yet)

            // Pause until next frame
            Thread.Sleep(100);
        }
        while ( ! finished );
    }
}
