// Galaxian Console

// Version + Date   Changes
// --------------   --------------------------------------
// 001, 26-Sep-18   Positioning on screen, changing colors

using System;

public class GalaxianConsole001
{
    public static void Main()
    {
        Console.SetCursorPosition(40, 10);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("W");
    }
}
