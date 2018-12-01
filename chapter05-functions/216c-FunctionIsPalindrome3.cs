// Function IsPalindrome
// Second approach (b), faster

//Ivan Lazcano

using System;

public class Palindrome
{
    public static bool IsPalindrome(string input)
    {
        for (int i = 0, j = input.Length-1; 
            i < input.Length / 2; 
            i++, j--)
        {
            if (input[i] != input[j])
                return false;
        }
        return true;
    }
    
    public static void Main()
    {
        Console.Write("Enter some text: ");
        string text = Console.ReadLine();
        Console.WriteLine(IsPalindrome(text));
    }
}
