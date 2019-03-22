//Kevin Marín Romero

using System;
using System.IO;

public class FileCopyBytes
{
    static void Main(string[] args)
    {
        string sourceName, destName;
        if (args.Length == 2)
        {
            sourceName = args[0];
            destName = args[1];
        }
        else
        {
            Console.Write("Enter the name of source file: ");
            sourceName = Console.ReadLine();
            Console.Write("Enter the name of destination file: ");
            destName = Console.ReadLine();
        }

        if(!File.Exists(sourceName))
        {
            Console.WriteLine("Source file Not Found");
        }
        else
        {
            if (File.Exists(destName))
            {
                Console.WriteLine("Destination file exists");
            }
            else
            {
                try
                {
                    FileStream fileIn = File.OpenRead(sourceName);
                    FileStream fileOut = File.Create(destName);

                    for (int i = 0; i < fileIn.Length; i++)
                    {
                        byte b = (byte)fileIn.ReadByte();
                        fileOut.WriteByte(b);
                    }

                    fileOut.Close();
                    fileIn.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine("IO: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
