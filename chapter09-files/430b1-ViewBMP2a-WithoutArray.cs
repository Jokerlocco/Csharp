//Kevin Marín Romero

using System;
using System.IO;


public class FileTest
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
            Console.Write("Enter the name of file to copy: ");
            name = Console.ReadLine();
        }

        if (!File.Exists(name))
        {
            Console.WriteLine("File Not Found");
        }
        else
        {
            BinaryReader file = new BinaryReader(File.Open(name,FileMode.Open));

            file.BaseStream.Seek(10,SeekOrigin.Begin);

            int start = file.ReadInt32();

            file.BaseStream.Seek(18, SeekOrigin.Begin);

            int width = file.ReadInt32();
            int height = file.ReadInt32();

            file.BaseStream.Seek(start,SeekOrigin.Begin);

            for (int i = height; i > 0; i--)
            {
                Console.SetCursorPosition(0,i);

                for (int j = 0; j < width; j++)
                {
                    if (file.ReadByte() < 127)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
            }

            Console.SetCursorPosition(0,height);

            Console.WriteLine();

            file.Close();
        }
    }
}