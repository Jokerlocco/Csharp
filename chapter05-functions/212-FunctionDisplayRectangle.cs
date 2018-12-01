using System;

public class FunctionRectangle
{
    public static void DisplayRectangle(
      int width, int height, char symbol)
    {
        string line = new string(symbol, width);
        for(int i = 0; i<height; i++)
            Console.WriteLine(line);
    }
    
    public static void Main()
    {
        DisplayRectangle(40, 10, 'W');
    }
}
