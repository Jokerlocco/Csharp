using System;

public class Reverse3
{
    public static void Main()
    {
        string[] words = Console.ReadLine().Split();
        Array.Reverse(words);
        Console.WriteLine( String.Join(" ", words) );
    }
}
