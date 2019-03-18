/*
Create a program to read a text file and dump its contents
to another text file, removing the redundant spaces (leading,
trailing and duplicated).
*/

using System;
using System.IO;

public class RedundantSpaces
{
    public static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("No file name!");
        }
        else
        {
            string name = args[0];
            if (!File.Exists(name))
                Console.WriteLine("File not found!");
            else
            {
                StreamReader input = new StreamReader(name);
                StreamWriter output = new StreamWriter(name+"nspc.txt");
                string line = input.ReadLine();
                while (line != null)
                {
                    line = line.Trim();
                    while (line.Contains("  "))
                        line = line.Replace("  "," ");
                    output.WriteLine(line);
                    line = input.ReadLine();
                } 
                output.Close();
                input.Close();
            }
        }
    }
}
