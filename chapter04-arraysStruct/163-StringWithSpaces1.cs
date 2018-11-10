/*
Nacho -> "N a c h o "
*/

using System;

public class StringWithSpaces
{
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        foreach (char c in sentence)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < sentence.Length; i++)
        {
            Console.Write(sentence[i] + " ");
        }
        Console.WriteLine();
    }
}
