/*
Nacho -> "N a c h o "
*/

using System;

public class StringWithSpaces2
{
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        // Last char as an special case
        for (int i = 0; i < sentence.Length-1; i++)
        {
            Console.Write(sentence[i] + " ");
        }
        Console.WriteLine(sentence[sentence.Length - 1]);

        // First char as an special case
        Console.Write(sentence[0]);
        for (int i = 1; i < sentence.Length; i++)
        {
            Console.Write(" " + sentence[i]);
        }
        Console.WriteLine();
    }
}
