// Adrián Navarro Gabino

using System;

public class FunctionDisplayRoundedRectangle
{
    public static void DisplayRoundedRectangle(int w, int h)
    {
        Console.WriteLine("/" + new string('-', w - 2) + "\\");
        
        for(int i = 0; i < h - 2; i++)
            Console.WriteLine("|" + new string(' ', w - 2) + "|");
        
        Console.WriteLine("\\" + new string('-', w - 2) + "/");
    }
    
    public static void Main()
    {
        DisplayRoundedRectangle(8, 3);
    }
}
