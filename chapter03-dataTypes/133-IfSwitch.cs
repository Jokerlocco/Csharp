// Jorge Calzada Asenjo
// Comparar varios caracteres

using System;

public class IfSwitch
{
    public static void Main()
    {
        char caracter;

        Console.Write("Enter a character: ");
        caracter = Convert.ToChar(Console.ReadLine());

        switch (caracter)
        {
            case '(':
            case ')': Console.WriteLine("Parentheses"); break;
            case '{':
            case '}': Console.WriteLine("Curly braces"); break;
            case '[':
            case ']': Console.WriteLine("Square brackets"); break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9': Console.WriteLine("Digit"); break;
            default: Console.WriteLine("Another symbol"); break;
        }

        if (caracter == '(' || caracter == ')')
        {
            Console.WriteLine("Parentheses");
        }
        else if (caracter == '{' || caracter == '}')
        {
            Console.WriteLine("Curly braces");
        }
        else if (caracter == '[' || caracter == ']')
        {
            Console.WriteLine("Square brackets");
        }
        else if (caracter >= '0' && caracter <= '9')
        {
            Console.WriteLine("Digit");
        }
        else
        {
            Console.WriteLine("Another symbol");
        }
    }
}
