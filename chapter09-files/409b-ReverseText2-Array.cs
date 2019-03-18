// Reversing a text file
// Sergio Ruescas

using System;
using System.IO;

class Reverse
{
    public static void Main(string[] args)
    {
        string fileName;
        if (args.Length > 0)
        {
            fileName = args[0];
        }
        else
        {
            Console.Write("Enter file name: ");
            fileName = Console.ReadLine();
        }

        if (File.Exists(fileName))
        {
            String[] lines;
            try
            {
                lines = File.ReadAllLines(fileName);
                StreamWriter file = File.CreateText(fileName + "_Reversed.txt");
                for (int i = lines.Length-1; i >= 0; i--)
                {
                    file.WriteLine(lines[i]);
                }
                file.Close();
            }
            catch(IOException e)
            {
                Console.WriteLine("I/O ERROR: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR " + e.Message);
            }
        }
        else
            Console.WriteLine("NOT FOUND");
            
    }
}
