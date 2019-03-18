// Reversing a text file
// V5: List + Reverse, based on Adrián Navarro Gabino

using System;
using System.IO;
using System.Collections.Generic;

class ReverseLines
{
    static void Main(string[] args)
    {
        string name;
        
        if(args.Length > 0)
        {
            name = args[0];
        }
        else
        {
            Console.Write("Name of the file: ");
            name = Console.ReadLine();
        }

        try
        {
            if(File.Exists(name))
            {
                List<string> lines = new List<string>(
                    File.ReadAllLines(name));
                lines.Reverse();
                File.WriteAllLines(name + ".reverse.txt", lines.ToArray());
            }
            else
                Console.WriteLine("File not found");
        }
        catch(IOException e)
        {
            Console.WriteLine("IO Exception: " + e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
    }
}
