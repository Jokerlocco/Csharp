// Blanks in a binary file
// Ivan Lazcano Sindin
using System;
using System.IO;

class BlanksInABinaryFile
{
    public static void Main(string[] args)
    {
        string name;
        if (args.Length != 1)
        {
            Console.WriteLine("Name of file?");
            name = Console.ReadLine();

        }
        else
            name = args[0];

        if (!File.Exists(name))
        {
            Console.WriteLine("Wrong name");
        }
        else
        {
            int countSpaces = 0;
            FileStream readFile = new FileStream(name, FileMode.Open);
            for (int i = 0; i < readFile.Length; i++)
            {
                if (readFile.ReadByte() == ' ')
                    countSpaces++;
            }

            readFile.Close();
            Console.WriteLine("Amount of spaces: " + countSpaces);
        }

    }
}
