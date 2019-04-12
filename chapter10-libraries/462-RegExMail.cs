using System;
using System.Text.RegularExpressions;

class RegularExpresion
{
    public static bool Regex(string s)
    {
        Regex r = new Regex(@"\A[a-z]+\@[a-z]+\.[a-z]{2,4}");
        return r.IsMatch(s);
    }

    public static void Main()
    {
        Console.WriteLine("Enter email: ");
        string email = Console.ReadLine();
        
        Console.WriteLine(Regex(email));
    }
}
