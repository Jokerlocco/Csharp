/*
Create a program that asks the user for a string and:

- Converts it to uppercase (storing the result in a new string)
- Converts it to lowercase (storing the result in a new string)
- Removes the second letter and the third letter (storing the result in a new string)
- Inserts "yo" after the second letter (storing the result in a new string)
- Replaces all spaces with underscores (storing the result in a new string)
- Removes leading spaces (storing the result in another string)
- Removes trailing spaces (storing the result in another string)
- Replaces all lowercase A by uppercase A (storing the result in another string)
- Split the text into an array of words which where separated by spaces and 
  display those words, each on in a line.

The program must display all the strings it generates.
*/

using System;

class StringsManipulation
{
    static void Main()
    {
        string sentence, result;
        
        // Ask the user for a string
        Console.WriteLine("Enter a sentence...");
        sentence = Console.ReadLine();

        // -Converts it to uppercase
        result = sentence.ToUpper();
        Console.WriteLine(result);

        // - Converts it to lowercase
        result = sentence.ToLower();
        Console.WriteLine(result);

        // - Removes the second letter and the third letter
        result = sentence.Remove(1 , 2);
        Console.WriteLine(result);

        // - Inserts "yo" after the second letter
        result = sentence.Insert(2, "yo");
        Console.WriteLine(result);

        // - Replaces all spaces with underscores
        result = sentence.Replace(" ", "_");
        Console.WriteLine(result);

        // - Removes leading spaces
        result = sentence.TrimStart();
        Console.WriteLine(result);

        // - Removes trailing spaces
        result = sentence.TrimEnd();
        Console.WriteLine(result);

        // - Replaces all lowercase A by uppercase A
        result = sentence.Replace("a", "A");
        Console.WriteLine(result);

        // - Split the text into an array of words which where separated
        //   by spaces and display those words, each on in a line.
        string[] parts = sentence.Split();
        foreach (string word in parts)
            Console.WriteLine(word);
    }
}
