// Function IsPalindrome
// First approach, slow

using System;

public class Palindrome
{
    public static bool IsPalindrome(string s)
    {
        string reversed = "";
        for(int i = s.Length-1; i >= 0; i--)
        {
            reversed += s[i];
        }
        if (s == reversed)
            return true;
        else
            return false;
    }
    
    public static void Main()
    {
        Console.Write("Enter some text: ");
        string text = Console.ReadLine();
        Console.WriteLine(IsPalindrome(text));
    }
}
