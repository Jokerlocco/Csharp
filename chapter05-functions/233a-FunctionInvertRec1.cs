using System;

public class FunctionInvertRecursive
{
    public static string Invert(string s)
    {
        if (s.Length <= 1)
        {
            return s;
        }
        else
        {
            return s[s.Length - 1] 
                + Invert(s.Substring(0, s.Length - 1));
        }
    }

    public static void Main()
    {
        string text = Console.ReadLine();
        Console.Write(Invert(text));
    }
}
