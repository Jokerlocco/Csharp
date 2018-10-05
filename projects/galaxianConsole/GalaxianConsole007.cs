// Galaxian Console

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 007, 04-Oct-18   Nacho: Simultaneous movement (too fast)
// 006, 04-Oct-18   J.Calzada, JC.Mendoza: Enemy moves to both sides (2: speed)
// 005, 04-Oct-18   S.Ruescas, S.Canovas: Enemy moves to both sides (1: flag)
// 004, 04-Oct-18   J.Rebollo, I.Lazcano: Enemy moves to the right
// 003, 27-Sep-18   J.V.Anton, D.Contreras: Console.ReadKey
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
        int enemySpeed = 2;
        int finished = 0;

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
            if (Console.KeyAvailable)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow)
                    xShip = xShip - 3;
                if (key.Key == ConsoleKey.RightArrow)
                    xShip = xShip + 3;
                if (key.Key == ConsoleKey.Escape)
                    finished = 1;
            }
            // Update world
            if ((xEnemy <= 5) || (xEnemy >= 75))
                enemySpeed = -enemySpeed;

            xEnemy = xEnemy + enemySpeed;

            // Check game status
            // (Not yet)

            // Pause until next frame
            // (Not yet)
        }
        while (finished == 0);
    }
}
