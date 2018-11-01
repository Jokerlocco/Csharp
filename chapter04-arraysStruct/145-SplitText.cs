// Gonzalo Arques
// Split a sentence into words

using System;
class SplitASentence
{
    static void Main()
    {
        Console.Write("Enter some text: ");
        string[] words = Console.ReadLine().Split();

        for (int i = 0; i < words.Length; i++)
            Console.WriteLine(words[i]);
    }
}
