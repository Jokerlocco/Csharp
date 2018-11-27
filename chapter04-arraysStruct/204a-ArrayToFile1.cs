//Ivan Lazcano
using System;
using System.IO;

public class SortFile
{
    public static void Main()
    {
        Console.WriteLine("File name? ");
        string name = Console.ReadLine();

        if (File.Exists(name))
        {
            string[] content = File.ReadAllLines(name);

            for (int i = 0; i < content.Length - 1; i++)
            {
                for (int j = 0; j < content.Length; j++)
                {
                    if (content[j].CompareTo(content[j]) > 0)
                    {
                        string aux = content[i];
                        content[i] = content[j];
                        content[i] = aux;
                    }
                }
            }

            File.WriteAllLines(name + ".sorted.txt", content);
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}
