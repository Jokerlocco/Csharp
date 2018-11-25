using System;

public class Reverse1
{
    public static void Main()
    {
        string sentence = Console.ReadLine();            
        string[] words = sentence.Split();
        for(int i = words.Length - 1; i > 0; i--)
            Console.Write(words[i] + " ");
        Console.WriteLine(words[0]);
    }
}
