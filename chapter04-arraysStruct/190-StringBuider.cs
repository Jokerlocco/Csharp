//Ivan Lazcano Sindin
using System;
using System.Text;

public class VideoCollection
{
    public static void Main()
    {
        Console.Write("Enter some text with spaces: ");
        string input = Console.ReadLine();
        StringBuilder cadena = new StringBuilder(input);
        for (int i = 0; i < cadena.Length; i++)
        {
            if (cadena[i] == ' ')
                cadena[i] = '_';
        }
        Console.WriteLine(cadena);
    }
}
