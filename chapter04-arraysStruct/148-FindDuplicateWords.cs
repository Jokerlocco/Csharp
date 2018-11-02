// Adrián Navarro Gabino
// Finding duplicate words

using System;

public class PalabraEnTexto2
{
    public static void Main()
    {
        Console.WriteLine("Enter some text: ");
        string[] sentence = Console.ReadLine().Split();
        
        bool isRepeated = false;
        string repeatedWord = "";
        
        for(int i = 0; i < sentence.Length; i++)
        {
            for(int j = i + 1; j < sentence.Length; j++)
            {
                if(sentence[i] == sentence[j])
                {
                    isRepeated = true;
                    repeatedWord = sentence[i];
                }
            }
        }
        
        if(isRepeated)
            Console.WriteLine(repeatedWord + " is repeated");
        else
            Console.WriteLine("There are no repeated words");
    }
}
