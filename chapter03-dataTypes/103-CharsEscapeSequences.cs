//ask for 3 letters and display them reversed
//Daniel Contreras

using System;

class InverseLetterOrder
{
    static void Main()
    {
        Console.Write("Enter letter: ");
        char letter1 = Convert.ToChar(Console.ReadLine());
        
        Console.Write("Enter letter: ");
        char letter2 = Convert.ToChar(Console.ReadLine());
        
        Console.Write("Enter letter: ");
        char letter3 = Convert.ToChar(Console.ReadLine());
        
        Console.Write("letters are: {2}\n\"{1}{0}\"",
            letter1, letter2, letter3);
    }
}
