// Jaime Francisco Rebollo Domínguez
// Finding a word in a sentence (1: correct version, bool)

using System;

public class WordsFinder
{
    public static void Main()
    {
        string keyword;
        bool found = false;
        
        Console.Write("Enter a sentence: ");
        string[] sentence = Console.ReadLine().Split();
        Console.Write("Enter a word: ");
        keyword = Console.ReadLine();
        
        foreach(string word in sentence)
        {
            if(word == keyword)
            {
                found = true;
            }
        }
        
        if(found)
        {
            Console.WriteLine("\"{0}\" found.", keyword);
        }
        else
        {
            Console.WriteLine("\"{0}\" not found.", keyword);
        }
    }
}
