// Galaxian Console

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 013, 25-Oct-18   A.Navarro, M.Isidro: collisions between fire and enemies
// 012, 18-Oct-18   I.Lazcano, J.Benajes: "fire" only when spacebar is pressed
// 011, 18-Oct-18   K.Marín A.Navarro: "fire" (always moving upwards)
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

        int xEnemy1 = 40, yEnemy1 = 10;
        int enemySpeed1 = 1;
        bool enemy1Alive = true;

        int xEnemy2 = 30, yEnemy2 = 15; ;
        int enemySpeed2 = -1;
        bool enemy2Alive = true;

        int xFire = xShip, yFire = 21;
        int fireSpeed = 1;
        bool activeFire = false;

        ConsoleKeyInfo key;
        bool finished = false;

        do
        {
            // Draw elements
            Console.Clear();

            if (enemy1Alive)
            {
                Console.SetCursorPosition(xEnemy1, yEnemy1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("W");
            }

            if (enemy2Alive)
            {
                Console.SetCursorPosition(xEnemy2, yEnemy2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("W");
            }

            Console.SetCursorPosition(xShip, 22);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("A");

            if (activeFire)
            {
                Console.SetCursorPosition(xFire, yFire);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|");
            }

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
                if (key.Key == ConsoleKey.Spacebar)
                {
                    xFire = xShip;
                    activeFire = true;
                }
            }

            // Update world
            if ((xEnemy1 <= 5) || (xEnemy1 >= 75))
                enemySpeed1 = -enemySpeed1;
            xEnemy1 = xEnemy1 + enemySpeed1;

            if ((xEnemy2 <= 5) || (xEnemy2 >= 75))
                enemySpeed2 = -enemySpeed2;
            xEnemy2 = xEnemy2 + enemySpeed2;


            if (yFire <= 2)
            {
                yFire = 21;
                activeFire = false;
            }
            if (activeFire)
                yFire = yFire - fireSpeed;

            // Check game status

            if (enemy1Alive && yEnemy1 == yFire && xEnemy1 == xFire)
                enemy1Alive = false;

            if (enemy2Alive && yEnemy1 == yFire && xEnemy2 == xFire)
                enemy2Alive = false;

            if (!enemy1Alive && !enemy2Alive)
                finished = true;

            // Pause until next frame
            Thread.Sleep(100);
        }
        while (!finished);

        Console.Clear();
        if (!enemy1Alive && !enemy2Alive)
            Console.WriteLine("You won!");
        else
            Console.WriteLine("You quitted :-(");
    }
}
