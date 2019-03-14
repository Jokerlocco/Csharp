// File to uppercase
// Version 1b: StreamReader + StreamWriter, 
//    constructor

using System;
using System.IO;

public class FileToUpper1b
{
    public static void Main()
    {
        Console.Write("Enter the file name: ");
        string name = Console.ReadLine();
        StreamReader input = new StreamReader(name);
        StreamWriter output = new StreamWriter( name + ".upper.txt");
        
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
