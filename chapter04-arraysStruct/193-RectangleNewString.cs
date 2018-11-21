using System;

public class RectangleNewString
{
    public static void Main()
    {
        Console.Write("Width of the rectangle? ");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Height of the rectangle? ");
        int height = Convert.ToInt32(Console.ReadLine());
        
        string line = new string('#', width);
        string spaces = new string(' ', width-2);
        
        Console.WriteLine(line);
        for (int i = 0; i < height-2; i++)
        {
            Console.WriteLine("#" + spaces + "#");
        }
        Console.WriteLine(line);
    }
}
