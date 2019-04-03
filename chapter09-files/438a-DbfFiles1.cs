// Jorge Calzada Asenjo
// Fields of a DBF file

using System;
using System.IO;

public class DbfFiles
{
    public static void Main(string[] args)
    {
        string path;

        if (args.Length > 0)
        {
            path = args[0];
        }
        else
        {
            Console.Write("Enter the path of the file: ");
            path = Console.ReadLine();
        }

        if (!File.Exists(path))
        {
            Console.WriteLine("The path of the file is not valid");
        }
        else
        {
            try
            {
                BinaryReader inputFile = new BinaryReader(File.Open(path,
                    FileMode.Open));

                inputFile.BaseStream.Seek(8, SeekOrigin.Begin);
                int headerLength = inputFile.ReadInt16() - 1;
                int blocksInHeader = headerLength / 32;

                Console.WriteLine("There are " + (blocksInHeader - 1) +
                    " fields in the table:");

                string nameOfColumn;
                for (int i = 1; i < blocksInHeader; i++)
                {
                    inputFile.BaseStream.Seek(32 * i, SeekOrigin.Begin);

                    nameOfColumn = "";

                    for (int j = 0; j < 11; j++)
                    {
                        nameOfColumn += (char)inputFile.ReadByte();
                    }
                    Console.WriteLine(nameOfColumn);
                }

                inputFile.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("The file cannot be read");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
