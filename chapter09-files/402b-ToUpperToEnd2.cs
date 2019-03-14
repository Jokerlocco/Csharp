// File to uppercase
// Version 3b: ReadAllText + WriteAllText

using System;
using System.IO;

public class FileToUpper3b
{
    public static void Main()
    {
        Console.Write("Enter the file name: ");
        string name = Console.ReadLine();
        
        string text = File.ReadAllText(name);
        File.WriteAllText(name + ".upper3.txt", text.ToUpper() );
    }
}
