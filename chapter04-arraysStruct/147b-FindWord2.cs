//Jaime Francisco Rebollo Domínguez
// Finding a word in a sentence (2: incorrect version)

using System;

public class WordsFinder
{
    public static void Main()
    {
        string keyword;
        
        Console.Write("Enter a sentence: ");
        string[] sentence = Console.ReadLine().Split();
        Console.Write("Enter a word: ");
        keyword = Console.ReadLine();
        
        foreach(string word in sentence)
        {
            if(word == keyword)
            {
                Console.WriteLine("\"{0}\" found.", keyword);
            }
            else
            {
                // The next line is wrong: we cannot report until the end
                Console.WriteLine("\"{0}\" not found.", keyword);
            }
        }
    }
}
