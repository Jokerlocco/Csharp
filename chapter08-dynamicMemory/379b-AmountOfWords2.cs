/*
Amount of (different) words in a sentence
*/

using System;
using System.Collections;

public class AmountOfWords
{
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();
        SortedList list = new SortedList();

        string[] parts = text.ToLower().Split();

        foreach (string part in parts)
        {
            if (! list.Contains(part))
                list.Add(part, "");
        }
        Console.WriteLine(list.Count);
    }
}
