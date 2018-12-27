// ConsoleSnake

// Version + Date   Author + Changes
// --------------   -----------------------------------------------
// 001, 27-Dic-18   Nacho: Draws the map on screen, player movement

using System;
using System.Threading;

public class ConsoleSnake
{
    const int ROWS = 20;
    static string[] map;
    static int xSnake, ySnake;
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
        Console.SetCursorPosition(1, 22);
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
        // TO DO...
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
