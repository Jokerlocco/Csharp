// Function IsPalindrome
// Second approach (a), faster

// Adrián Navarro Gabino

using System;

public class Palindrome
{
    public static bool IsPalindrome(string entry)
    {
        for(int i = 0; i < entry.Length; i++)
        {
            if(entry[i] != entry[entry.Length - 1 - i])
            {
                return false;
            }
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
