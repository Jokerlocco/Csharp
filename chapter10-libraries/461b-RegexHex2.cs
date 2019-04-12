// José Vicente Antón Castelló

using System;
using System.Text.RegularExpressions;

public class Program
{
    static bool EsNumeroHexadecimal(string s)
    {
        Regex r = new Regex(
            @"\A[0-9A-Fa-f][0-9A-Fa-f]?([0-9A-Fa-f]?[0-9A-Fa-f]?\z");
        return r.IsMatch(s);
    }

    public static void Main(string[] args)
    {
        Console.Write("Introduce un número hexadecimal: ");
        string dato = Console.ReadLine();
        Console.WriteLine(EsNumeroHexadecimal(dato) ? "SI" : "NO");
    }
}

