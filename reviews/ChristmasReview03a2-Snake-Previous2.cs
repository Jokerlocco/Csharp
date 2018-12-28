// ConsoleSnake

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 002, 28-Dic-18   Nacho: Collision with walls, picking fruits, score
// 001, 27-Dic-18   Nacho: Draws the map on screen, player movement

using System;
using System.Threading;

public class ConsoleSnake
{
    const int ROWS = 20;
    static string[] map;
    static int xSnake, ySnake;
    static int fruits;
    static int score;
    static bool finished;

    public static void Init()
    {
        finished = false;
        xSnake = 10;
        ySnake = 2;
        map = new string[]
        {
            "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
            "X                      X     X",
            "X    F                 X     X",
            "X               F      X  F  X",
            "X     XXXXX            X     X",
            "X     X                X     X",
            "X     X        X       X     X",
            "X     X        X       X     X",
            "X              X       X     X",
            "X              X       X     X",
            "X              X       X     X",
            "X   F          X             X",
            "X              X             X",
            "X              X         F   X",
            "X      X            X        X",
            "X      X            X        X",
            "X      X       F     X       X",
            "X  F   X              X      X",
            "X      X              F      X",
            "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        };
        fruits = 7;
        score = 0;
    }


    public static void DrawElements()
    {
        Console.Clear();
        for (int i = 0; i < ROWS; i++)
        {
            Console.WriteLine(map[i]);
        }
        Console.SetCursorPosition(xSnake, ySnake);
        Console.WriteLine("o");

        Console.SetCursorPosition(50, 10);
        Console.WriteLine("Score: " + score);
        Console.SetCursorPosition(50, 14);
        Console.WriteLine("Remaining fruits: "+fruits);
        Console.SetCursorPosition(50, 18);
        Console.WriteLine("ESC to quit");
    }


    public static void ProcessUserInput()
    {
        ConsoleKeyInfo key;

        if (Console.KeyAvailable)
        {
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.LeftArrow)
                xSnake--;
            if (key.Key == ConsoleKey.RightArrow)
                xSnake++;
            if (key.Key == ConsoleKey.UpArrow)
                ySnake--;
            if (key.Key == ConsoleKey.DownArrow)
                ySnake++;
            if (key.Key == ConsoleKey.Escape)
                finished = true;
        }
    }


    public static void UpdateWorld()
    {
        // Collision with a wall?
        if (map[ySnake][xSnake] == 'X')
            finished = true;

        // Any fruit picked?
        if (map[ySnake][xSnake] == 'F')
        {
            // We remove it from the map
            map[ySnake] = map[ySnake].Remove(xSnake, 1).Insert(xSnake, " ");
            // And update the counters
            score += 10;
            fruits--;
        }
    }


    public static void CheckGameStatus()
    {
        // TO DO ...
    }


    public static void PauseUntilNextFrame()
    {
        Thread.Sleep(200);
    }


    public static void DisplayEndOfGame()
    {
        Console.Clear();
        if (fruits == 0)
            Console.WriteLine("You won!");
        else
            Console.WriteLine("You hit a wall");
        Console.WriteLine("Bye!");
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

        DisplayEndOfGame();
    }
}
