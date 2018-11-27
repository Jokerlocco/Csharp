using System;
using System.IO;

public class FileSorter
{
    public static void Main()
    {
        Console.WriteLine("File name? ");
        string name = Console.ReadLine();

        if (!File.Exists(name))
        {
            Console.WriteLine("File not found!");
        }
        else
        { 
            string[] content = File.ReadAllLines(name);
            Array.Sort(content);
            File.WriteAllLines(name + ".sorted.txt", content);
        }
    }
}
