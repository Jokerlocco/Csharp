// N 2018

using System;

class Snowflakes
{
    struct snowflake
    {
        public int x;
        public int y;
        public char symbol;
        public ConsoleColor color;
    }

    static void Main()
    {
        const int SIZE = 50;
        snowflake[] flakes = new snowflake[SIZE];

        // Init
        Console.Clear();
        Console.SetWindowSize(80, 25);
        Console.SetBufferSize(80, 25);
        Random r = new Random();
        for (int i = 0; i < SIZE; i++)
        {
            flakes[i].x = r.Next(80);
            flakes[i].y = r.Next(25);
            flakes[i].symbol = ".*"[r.Next(2)];
            flakes[i].color = r.Next(2) == 0 ? ConsoleColor.White : 
                ConsoleColor.Gray;
        }
        
        // Draw
        while( ! Console.KeyAvailable )
        {
            for (int i = 0; i < SIZE; i++)
            {
                Console.SetCursorPosition(flakes[i].x, flakes[i].y);
                Console.Write(" ");
                flakes[i].y++;
                if (flakes[i].y > 24) flakes[i].y = 0;
                Console.ForegroundColor = flakes[i].color;
                Console.SetCursorPosition(flakes[i].x, flakes[i].y);
                Console.Write(flakes[i].symbol);
            }
            Console.SetCursorPosition(0, 24);
            System.Threading.Thread.Sleep(200);
        }
    }
}
