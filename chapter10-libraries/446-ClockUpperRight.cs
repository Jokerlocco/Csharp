// Adrián Navarro Gabino

using System;
using System.Threading;

class ClockUpperRight
{
    static void Main()
    {
        Console.SetWindowSize(80,25);
        Console.SetBufferSize(80,25);
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Cyan;
        while(true)
        {
            Console.SetCursorPosition(70,0);
            Console.WriteLine(DateTime.Now.Hour.ToString("00") + ":" +
                DateTime.Now.Minute.ToString("00") + ":" +
                DateTime.Now.Second.ToString("00"));
            Thread.Sleep(1000);
        }
    }
}
