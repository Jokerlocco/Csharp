// Gonzalo Arques
using System;
using System.Text.RegularExpressions;

public class Regex1
{
    public static void Main()
    {
        Console.WriteLine("Enter the identifier: ");
        string dato = Console.ReadLine();

        Console.WriteLine(IsValidIdentifier(dato));
    }

    public static bool IsValidIdentifier(string s)
    {
        Regex r = new Regex(@"\A[a-zA-Z][A-Za-z0-9]*\z");
        return r.IsMatch(s);
    }
}
