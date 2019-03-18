// Reversing a text file
// Kevin Marín Romero

using System;
using System.Collections.Generic;
using System.IO;

public class ReverseFile
{
    static void Main(string[] args)
    {
        string name;
        if (args.Length == 1)
        {
            name = args[0];
        }
        else
        {
            Console.Write("Enter the file name: ");
            name = Console.ReadLine();
        }
        
        if (!File.Exists(name))
        {
            Console.WriteLine("File Not Found.");
        }
        else
        {
            try
            {
                StreamReader fileIn = File.OpenText(name);
                StreamWriter fileOut = File.CreateText(name + ".reverse.txt");

                string line;
                Stack<string> textReversed = new Stack<string>();

                do
                {
                    line = fileIn.ReadLine();

                    if (line != null)
                    {
                        textReversed.Push(line);
                    }
                } while (line != null);

                while(textReversed.Count > 0)
                {
                    fileOut.WriteLine(textReversed.Pop());
                }

                fileOut.Close();
                fileIn.Close();

            }
            catch (IOException e )
            {
                Console.WriteLine("I/O error: "+ e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
