/*
Create a function to calculate the number of vowels (both uppercase and 
lowercase) and spaces in a text string. It will accept three parameters: the 
string to analyze, the variable to return the amount of vowels and the variable 
to return the amount of spaces, in this order. The function should be named 
“CountVS”. It would be used in a very similar  way to:

CountVS ("This is THE SENTENCE", amountOfVowels, amountOfSpaces)

amountOfVowels would be 6 and amountOfSpaces would be 3
*/

//Manuel Rojas Henarejos

using System;

public class CountVowelsSpaces
{
    public static void CountVS (string sentence, out int vw, out int spc)
    {
        vw = 0;
        spc = 0;
        string ToFind = "aeiou";
        
        for (int i = 0; i < sentence.Length; i++)
        {
            if (ToFind.Contains(Convert.ToString(sentence.ToLower()[i])))
            {
                vw++;
            }
        }
        
        string SpaceLess = sentence.Replace(" " , "");
        
        spc = sentence.Length - SpaceLess.Length;
    }
    
    
    public static void Main()
    {
        int vowels;
        int spaces;
        
        CountVS("This is THE SENTENCE", out vowels, out spaces);
        Console.WriteLine(
            "Total vowels: {0}, total spaces: {1}", vowels, spaces);
    }
}
