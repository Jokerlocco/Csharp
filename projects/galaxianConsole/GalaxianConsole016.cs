// Galaxian Console

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 016, 29-Nov-18   Nacho: Functions
// 015, 15-Nov-18   A.Navarro, C.Francés, K.Marín: several enemies (struct)
// 014, 08-Nov-18   A.Navarro, J.Rebollo: several enemies (array)
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
    struct enemy
    {
        public int x;
        public int y;
        public bool alive;
    }

    const int SIZEENEMY = 20;
    static enemy[] e;
    static int xShip = 40;
    static int speedForAllEnemies = 1;
    static int xFire = xShip, yFire = 21;
    static int fireSpeed = 1;
    static bool activeFire = false;
    static bool finished = false;
    static int finishedCount = 0;


    public static void Init()
    {
        e = new enemy[SIZEENEMY];

        for (int i = 0; i < SIZEENEMY; i++)
        {
            e[i].x = 10 + 3 * i;
            e[i].y = 10;
            e[i].alive = true;
        }
    }


    public static void DrawElements()
    {
        Console.Clear();
        for (int i = 0; i < SIZEENEMY; i++)
        {
            if (e[i].alive)
            {
                Console.SetCursorPosition(e[i].x, e[i].y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("W");
            }
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
    }


    public static void ProcessUserInput()
    {
        ConsoleKeyInfo key;

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
    }


    public static void UpdateWorld()
    {
        // First, let's move all the enemies
        for (int i = 0; i < SIZEENEMY; i++)
        {
            e[i].x = e[i].x + speedForAllEnemies;
        }

        // Then let's see if all of them must change direction
        for (int i = 0; i < SIZEENEMY; i++)
        {
            if (e[i].x <= 5)
            {
                speedForAllEnemies = 1;
            }
            else if (e[i].x >= 75)
            {
                speedForAllEnemies = -1;
            }
        }

        // Finally, let's move the fire
        if (yFire <= 2)
        {
            yFire = 21;
            activeFire = false;
        }
        if (activeFire)
            yFire = yFire - fireSpeed;
    }


    public static void CheckGameStatus()
    {
        for (int i = 0; i < SIZEENEMY; i++)
        {
            if (e[i].alive && e[i].y == yFire && e[i].x == xFire)
            {
                e[i].alive = false;
                finishedCount++;
            }
            if (finishedCount == e.Length - 1)
                finished = true;
        }
    }


    public static void PauseUntilNextFrame()
    {
        Thread.Sleep(100);
    }


    public static void DisplayFinalReport()
    {
        Console.Clear();

        if (finishedCount == e.Length - 1)
            Console.WriteLine("You won!");
        else
            Console.WriteLine("You quitted :-(");
    }


    public static void Main()
    {
        Init();

        do
        {
            DrawElements();
            ProcessUserInput();
            UpdateWorld();
            CheckGameStatus();
            PauseUntilNextFrame();
        }
        while (!finished);

        DisplayFinalReport();
    }
}
