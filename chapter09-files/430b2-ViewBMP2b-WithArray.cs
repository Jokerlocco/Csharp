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

            file.BaseStream.Seek(34,SeekOrigin.Begin);

            int size = file.ReadInt32();

            file.BaseStream.Seek(start,SeekOrigin.Begin);

            string[] image = new string[height];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    byte p = file.ReadByte();
                    if(p < 127)
                    {
                        image[i] += (".");
                    }
                    else
                    {
                        image[i] += ("*");
                    }
                }
            }

            Array.Reverse(image);

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine(image[i]);
            }

            file.Close();
        }
    }
}