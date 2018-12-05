// Javier Benajes

using System;

public class FunctionInvert1
{
    public static string Invert(string s)
    {
        string inverted = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            inverted += s[i];
        }
        return inverted;
    }

    public static void Main()
    {
        string text = Console.ReadLine();
        Console.Write(Invert(text));
    }
}
