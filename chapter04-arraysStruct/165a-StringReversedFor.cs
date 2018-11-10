//Kevin Marín Romero

using System;

public class StringReversedFor
{
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        string inverted = "";

        for (int i = sentence.Length - 1; i >= 0; i--)
        {
            inverted += sentence[i];
        }
        Console.WriteLine(inverted);
    }
}
