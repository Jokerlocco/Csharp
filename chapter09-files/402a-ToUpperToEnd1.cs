// File to uppercase
// Version 3a: ReadAllText + StreamWriter

using System;
using System.IO;

public class FileToUpper3a
{
    public static void Main()
    {
        Console.Write("Enter the file name: ");
        string name = Console.ReadLine();
        
        string text = File.ReadAllText(name);
        
        StreamWriter output = File.CreateText(name + ".upper3.txt");
        output.Write( text.ToUpper() );
        output.Close();
    }
}
