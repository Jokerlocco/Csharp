using System;

public class TestForEach
{
    public static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();
        
        
        for(int i = 0; i < text.Length; i++)
        {
            Console.Write("{0} ", text[i]);
        }


        foreach(char letter in text)
        {
            Console.Write("{0} ", letter);
        }
        
    }
    
}
