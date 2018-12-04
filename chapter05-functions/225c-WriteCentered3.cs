// Adrián Navarro Gabino

using System;

public class WriteCentered3
{
    public static void WriteCentered(string sentence)
    {
        int size = sentence.Length;
        int position = (80 - size) / 2;
        string spaces = new string(' ',position);
        Console.WriteLine(spaces + sentence);
    }
    
    
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        
        WriteCentered(sentence);
    }
}
