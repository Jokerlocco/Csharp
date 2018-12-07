// Initials, more robust version

using System;
public class FunctionInitials1
{
    public static string Initials (string text)
    {
        text = text.Trim();
        string result = text[0] + "";
        for (int i = 1; i < text.Length; i++)
        {
            if ((text[i - 1] == ' ') && (text[i] != ' '))
                result += text[i];
        }

        return result.ToUpper();
    }

    public static void Main()
    {
        Console.WriteLine(Initials(" asd Dd  ww gg  "));
    }
}
