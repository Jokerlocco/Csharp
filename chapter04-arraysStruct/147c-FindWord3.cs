// Jaime Francisco Rebollo Domínguez
// Finding a word in a sentence (3: correct version, count)

using System;

public class WordsFinder
{
    public static void Main()
    {
        string keyword;
        int count = 0;
        
        Console.Write("Enter a sentence: ");
        string[] sentence = Console.ReadLine().Split();
        Console.Write("Enter a word: ");
        keyword = Console.ReadLine();
        
        foreach(string word in sentence)
        {
            if(word == keyword)
            {
                count++;
            }
        }
        
        if(count > 0)
        {
            Console.WriteLine("\"{0}\" found {1} times.", keyword, count);
        }
        else
        {
            Console.WriteLine("\"{0}\" not found.", keyword);
        }
    }
}
