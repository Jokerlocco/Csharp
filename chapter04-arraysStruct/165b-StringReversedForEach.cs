using System;

public class StringReversedForEach
{
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        string inverted = "";

        foreach (char c in sentence)
        {
            inverted = c + inverted;
        }
        Console.WriteLine(inverted);
    }
}
