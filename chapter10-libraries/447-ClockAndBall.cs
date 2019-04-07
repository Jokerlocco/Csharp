// Adrián Navarro Gabino

using System;
using System.Threading;

class ClockAndBall
{
    static void Main()
    {
        Console.SetWindowSize(80,25);
        Console.SetBufferSize(80,25);
        
        Console.BackgroundColor = ConsoleColor.Blue;
        
        
        int x = 20;
        int y = 10;
        int xSpeed = 3;
        int ySpeed = 1;
        
        while(true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(70,0);
            Console.WriteLine(DateTime.Now.Hour.ToString("00") + ":" +
                DateTime.Now.Minute.ToString("00") + ":" +
                DateTime.Now.Second.ToString("00"));
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x, y);
            Console.Write("o");
            
            x += xSpeed;
            if (x < 5 || x > 75)
                xSpeed = -xSpeed;

            y += ySpeed;
            if (y < 2 || y > 23)
                ySpeed = -ySpeed;
            
            Console.SetCursorPosition(0, 0);
            Thread.Sleep(300);
            
            if(Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if(key.Key == ConsoleKey.S)
                    break;
            }
        }
    }
}
