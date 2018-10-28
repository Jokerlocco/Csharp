// Graph of a function
// Adrián Navarro Gabino

using System;

public class Grafica
{
    public static void Main()
    {
        for(int x = 30; x >= -30; x--)
        {
            double y = Math.Sqrt(Math.Abs(x) * 10);
            Console.SetCursorPosition(x + 30, 23 - (int) y);
            Console.WriteLine("*");
        }
        Console.SetCursorPosition(0,0);
    }
}
