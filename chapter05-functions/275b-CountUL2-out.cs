// Count uppercase and lowercase
// Ivan Lazcano Sindin

using System;

public class CountUppercaseAndLowercase2
{
    public static void CountUL(string t, out int upper, out int lower)
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
        int u, l;
        CountUL("TextAAAds2233", out u, out l);
        Console.WriteLine(u + " " + l);
    }
}
