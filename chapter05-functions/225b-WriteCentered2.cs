//Ivan Lazcano
using System;

public class WriteCentered2
{
    public static void WriteCentered(string text)
    {
        int mid = 40 - text.Length / 2;
        string whiteSpaces = new string(' ', mid);
        Console.Write(whiteSpaces);
        Console.WriteLine(text);
    }

    public static void Main()
    {
        WriteCentered("Hola");
    }
}
