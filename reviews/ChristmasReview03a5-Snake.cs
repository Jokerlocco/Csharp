// ConsoleSnake

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 005, 02-Ene-19   Nacho: Several levels
// 004, 30-Dic-18   Nacho: Snake can grow
// 003, 29-Dic-18   Nacho: Automatic movement
// 002, 28-Dic-18   Nacho: Collision with walls, picking fruits, score
// 001, 27-Dic-18   Nacho: Draws the map on screen, player movement

using System;
using System.Threading;

public class ConsoleSnake
{
    const int ROWS = 20;
    static string[,] map;
    static int currentMap;
    static int xSpeed, ySpeed;
    static int fruits;
    static int score;
    static bool finished;

    const int MAX_SNAKE_SIZE = 20;
    static int currentSnakeSize;
    static int[] xSnake = new int[MAX_SNAKE_SIZE];
    static int[] ySnake = new int[MAX_SNAKE_SIZE];

    public static void Init()
    {
        currentMap = 0;
        finished = false;
        xSnake[0] = 10;
        ySnake[0] = 2;
        currentSnakeSize = 1;
        map = new string[,]
        {
            {
            "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
            "X               F      X     X",
            "X    F                 X     X",
            "X               F      X  F  X",
            "X     XXXXX            X     X",
            "X     X            F   X     X",
            "X  F  X    F   X       X F   X",
            "X     X        X       X     X",
            "X              X    F  X     X",
            "X         F    X       X   F X",
            "X              X       X     X",
            "X   F          X F           X",
            "X         F    X             X",
            "X              X         F   X",
            "X      X            X        X",
            "X      X            X        X",
            "X      X       F     X     F X",
            "X  F   X   F          X      X",
            "X      X              F      X",
            "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
            },
            {
            "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
            "X      F  X       X    X     X",
            "X  F      X            X     X",
            "XXXXXX          F      X  F  X",
            "XF                     X     X",
            "X     X  XX   XXX      X     X",
            "X     X FX      X  F   X  X  X",
            "X     X  XF     X      X     X",
            "X               X      X     X",
            "X     F    X           X   X X",
            "X          X F  X  F   X     X",
            "X          X    X            X",
            "X          X    X            X",
            "X               X        F   X",
            "X   XF X            X  X     X",
            "X   X  X            XFFX     X",
            "X   X  X       F   X       F X",
            "X  FX  X          X          X",
            "X         F           F      X",
            "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
            }
        };
        score = 0;
        xSpeed = 1;
        ySpeed = 0;
    }


    public static void DrawElements()
    {
        //Console.Clear();
        Console.SetCursorPosition(0, 0);
        fruits = 0;
        for (int i = 0; i < ROWS; i++)
        {
            for (int j = 0; j < map[currentMap, i].Length; j++)
            {
                if (map[currentMap, i][j] == 'F')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    fruits++;
                }
                if (map[currentMap, i][j] == 'X')
                    Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(map[currentMap, i][j]);
            }
            Console.WriteLine();
        }

        Console.ForegroundColor = ConsoleColor.Red;
        for (int i = 0; i < currentSnakeSize; i++)
        {
            Console.SetCursorPosition(xSnake[i], ySnake[i]);
            Console.WriteLine("o");
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(50, 10);
        Console.WriteLine("Score: " + score);
        Console.SetCursorPosition(50, 14);
        Console.WriteLine("Remaining fruits: " + fruits);
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
            {
                xSpeed = -1;
                ySpeed = 0;
            }
            if (key.Key == ConsoleKey.RightArrow)
            {
                xSpeed = 1;
                ySpeed = 0;
            }
            if (key.Key == ConsoleKey.UpArrow)
            {
                xSpeed = 0;
                ySpeed = -1;
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                xSpeed = 0;
                ySpeed = 1;
            }
            if (key.Key == ConsoleKey.Escape)
                finished = true;
        }
    }


    public static void UpdateWorld()
    {
        // Move the snake
        for (int i = currentSnakeSize; i >= 1; i--)
        {
            xSnake[i] = xSnake[i-1];
            ySnake[i] = ySnake[i-1];
        }
        xSnake[0] += xSpeed;
        ySnake[0] += ySpeed;

        // Collision with a wall?
        if (map[currentMap, ySnake[0]][xSnake[0]] == 'X')
            finished = true;

        // Any fruit picked?
        if (map[currentMap, ySnake[0]][xSnake[0]] == 'F')
        {
            // We remove it from the map
            map[currentMap, ySnake[0]] = 
                map[currentMap, ySnake[0]].Remove(xSnake[0], 1).
                Insert(xSnake[0], " ");
            // Enlarge the snake
            currentSnakeSize++;
            // And update the counters
            score += 10;
            fruits--;
        }
    }


    public static void CheckGameStatus()
    {
        if (fruits == 0)
            currentMap++;

        if (currentMap == map.GetLength(0))
            finished = true;
    }


    public static void PauseUntilNextFrame()
    {
        Thread.Sleep(200);
    }


    public static void DisplayEndOfGame()
    {
        Thread.Sleep(500);
        Console.Clear();
        if (fruits == 0)
            Console.WriteLine("You won!");
        else
            Console.WriteLine("You hit a wall");
        Console.WriteLine("Bye!");
        Thread.Sleep(1000);
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
