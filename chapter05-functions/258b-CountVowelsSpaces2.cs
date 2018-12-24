/*
Create a function to calculate the number of vowels (both uppercase and 
lowercase) and spaces in a text string. It will accept three parameters: the 
string to analyze, the variable to return the amount of vowels and the variable 
to return the amount of spaces, in this order. The function should be named 
“CountVS”. It would be used in a very similar  way to:

CountVS ("This is THE SENTENCE", amountOfVowels, amountOfSpaces)

amountOfVowels would be 6 and amountOfSpaces would be 3
*/

// Manuel Lago

using System;

public class CountVowelsSpaces
{
    public static void CountVS ( string text, ref int vowels,
        ref int spaces)
    {
        vowels = 0;
        spaces = 0;
        text = text.ToUpper();

        for ( int i = 0 ; i < text.Length ; i++ )
        {
            if (text[i] == 'A' ||
                text[i] == 'E' ||
                text[i] == 'I' ||
                text[i] == 'O' ||
                text[i] == 'U')
            {
                vowels++;
            }
            
            if ( text[i] == ' ' )
            {
                spaces++;
            }
        }
    }
    
    public static void Main()
    {
        int vowels = 0;
        int spaces = 0;
        
        Console.Write("Enter the text: ");
        string text = Console.ReadLine();
        
        CountVS( text, ref vowels, ref spaces);
        
        Console.WriteLine("Vowels: " + vowels);
        Console.WriteLine("Spaces: " + spaces);
    }
}
