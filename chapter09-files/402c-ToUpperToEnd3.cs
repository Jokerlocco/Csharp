// File to uppercase
// Version 3c: ReadAllText + WriteAllText, 1 step

using System;
using System.IO;

public class FileToUpper3c
{
    public static void Main()
    {
        Console.Write("Enter the file name: ");
        string name = Console.ReadLine();
        
        File.WriteAllText(
            name + ".upper3.txt", 
            File.ReadAllText(name).ToUpper() );
    }
}
