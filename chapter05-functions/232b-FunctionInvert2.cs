// Inverting a string... with foreach

using System;

public class FunctionInvert2
{
    public static string Invert(string s)
    {
        string inverted = "";
        foreach (char c in s)
        {
            inverted = c + inverted;
        }
        return inverted;
    }

    public static void Main()
    {
        string text = Console.ReadLine();
        Console.Write(Invert(text));
    }
}
