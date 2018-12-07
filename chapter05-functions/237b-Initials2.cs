// Javier Benajes

using System;
public class FunctionInitials2
{
    public static string Initials(string s)
    {
        string[] words = s.Split();
        string initials = "";

        for (int i = 0; i < words.Length; i++)
        {
            initials += words[i][0];
        }

        return initials.ToUpper();
    }

    public static void Main()
    {
        string text = "Don Quijote de la Mancha";

        Console.WriteLine(Initials(text));
    }
}
