// Adrián Navarro Gabino

using System;

public class CenteredTriangle
{
    public static void WriteCenteredTriangle(char c, int width)
    {
        int amountOfSpaces = 40 - width / 2;
        int amountOfSymbols = width;
        
        for(int i = 0; i < (width + 1) / 2; i++)
        {
            
            string spaces = new string(' ', amountOfSpaces);
            string symbols = new string(c, amountOfSymbols);
            Console.WriteLine(spaces + symbols);
            
            amountOfSpaces++;
            amountOfSymbols -= 2;
        }
    }
    
    public static void Main()
    {
        WriteCenteredTriangle('#', 9);
    }
}
