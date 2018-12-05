using System;

public class FunctionInvertRecursive2
{
    public static string Invert(string s)
    {
        if (s.Length <= 1)
        {
            return s;
        }
        else
        {
            return Invert(s.Substring(1)) + s[0];
        }
    }

    public static void Main()
    {
        string text = Console.ReadLine();
        Console.Write(Invert(text));
    }
}
