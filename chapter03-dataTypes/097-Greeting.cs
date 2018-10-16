// Contact with strings (2) : testing equality

using System;

public class StringsEquals
{
    public static void Main()
    {
        Console.WriteLine("What's your name?");
        string name = Console.ReadLine();
        
        if (name == "Juan")
            Console.WriteLine ("Hello "  + name);
        else 
            Console.WriteLine(" Who are you?");
        
     }
 }
