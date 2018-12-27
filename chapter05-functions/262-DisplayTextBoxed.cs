//Ivan Lazcano Sindin

using System;

public class DisplayTextBoxedFunction
{
    public static void DisplayTextBoxed(string s)
    {
        Console.WriteLine("+" + new string('-', s.Length+4) + "+");
        Console.WriteLine("|  " + s + "  |");
        Console.WriteLine("+" + new string('-', s.Length + 4) + "+");
    }
    public static void Main(string[] args)
    {
        DisplayTextBoxed("Hola Mundo Cruel!");
    }
}
