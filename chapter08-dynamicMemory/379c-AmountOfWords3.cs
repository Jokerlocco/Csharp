/*
Amount of (different) words in a sentence
*/

using System;
using System.Collections.Generic;

public class AmountOfWords
{
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();
        Dictionary<string,bool> list = new Dictionary<string,bool>();

        string[] parts = text.ToLower().Split();

        foreach (string part in parts)
        {
            if (! list.ContainsKey(part))
                list.Add(part, true);
        }
        Console.WriteLine(list.Count);
    }
}
