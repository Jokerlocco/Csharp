// File to uppercase
// Version 1c: StreamReader + StreamWriter, 
//    using

using System;
using System.IO;

public class FileToUpper1c
{
    public static void Main()
    {
        Console.Write("Enter the file name: ");
        string name = Console.ReadLine();
        using (StreamReader input = new StreamReader(name))
        {
            using (StreamWriter output = 
                new StreamWriter( name + ".upper.txt"))
            {
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
            }
        }        
    }
}
