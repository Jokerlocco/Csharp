// Count uppercase and lowercase
// Ivan Lazcano Sindin

using System;

public class CountUppercaseAndLowercase
{
    public static void CountUL(string t, ref int upper, ref int lower)
    {
        upper = lower = 0;
        foreach(char l in t)
        {
            if (l >= 'a' && l <= 'z')
                lower++;
            else if (l >= 'A' && l <= 'Z')
                upper++;
        }
    }

    public static void Main()
    {
        int u = 0, l = 0;
        CountUL("TextAAAds2233", ref u, ref l);
        Console.WriteLine(u + " " + l);
    }
}
