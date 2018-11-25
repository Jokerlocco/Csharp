using System;

public class Reverse2
{
    public static void Main()
    {
        string sentence = Console.ReadLine();
        string[] words = sentence.Split();
        string answer = "";
        for(int i=0;i < words.Length; i++)
            answer = words[i] + " " + answer;
        Console.WriteLine( answer.TrimEnd() );
    }
}
