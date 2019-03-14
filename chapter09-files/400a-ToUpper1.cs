// File to uppercase
// Version 1a: StreamReader + StreamWriter, 
//    OpenText + CreateText

using System;
using System.IO;

public class FileToUpper1a
{
    public static void Main()
    {
        Console.Write("Enter the file name: ");
        string name = Console.ReadLine();
        StreamReader input = File.OpenText(name);
        StreamWriter output = File.CreateText( name + ".upper.txt");
        
        string line;
        do
        {
            line = input.ReadLine();
            if (line != null)
            {
                output.WriteLine( line.ToUpper() );
            }
        }
        while (line != null);
        
        input.Close();
        output.Close();
    }
}
