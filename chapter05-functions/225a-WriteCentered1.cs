// Javier Benajes Nadal

using System;

public class WriteCentered1
{
    public static void WriteCentered(string s)
    {
        int pos = 40 - (s.Length / 2);

        for (int i = 0; i < pos; i++)
        {
            Console.Write(" ");
        }
        Console.WriteLine(s);
    }

    public static void Main()
    {
        WriteCentered("Hello!");
    }
}
