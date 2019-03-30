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
            try
            {
                BinaryReader fileIn = 
                    new BinaryReader(File.Open(name,FileMode.Open));
                BinaryWriter fileOut = 
                    new BinaryWriter(File.Open(name +
                        ".2.bmp",FileMode.Create));

                int amountToRead = (int)fileIn.BaseStream.Length-2;

                byte b1 = fileIn.ReadByte();
                byte b2 = fileIn.ReadByte();

                fileOut.Write(b2);
                fileOut.Write(b1);

                for (int i = 0; i < amountToRead; i++)
                {
                    fileOut.Write( fileIn.ReadByte() );
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
