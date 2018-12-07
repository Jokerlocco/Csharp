//Ivan Lazcano Sindin

using System;
public class FunctionInitials1
{
    public static string Initials (string text)
    {
        string result = text[0] + "";
        for (int i = 1; i < text.Length; i++)
        {
            if (text[i - 1] == ' ')
                result += text[i];
        }

        return result.ToUpper();
    }

    public static void Main()
    {
        Console.WriteLine(Initials("asd dd ww gg"));
    }
}
