// File to uppercase
// Version 2: ReadAllLines + WriteAllLines

using System;
using System.IO;

public class FileToUpper2
{
    public static void Main()
    {
        Console.Write("Enter the file name: ");
        string name = Console.ReadLine();
        
        string[] lines = File.ReadAllLines(name);
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = lines[i].ToUpper();
        }
        File.WriteAllLines(name + ".upper2.txt", lines);
    }
}
