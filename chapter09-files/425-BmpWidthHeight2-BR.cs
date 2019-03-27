// BMP Width and height

using System;
using System.IO;

class BmpWidthAndHeight
{
    public static void Main()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();
        
        if (!File.Exists(fileName))
            Console.WriteLine("File not found!");
        else
        {
            try
            {
                BinaryReader input = new BinaryReader(
                    File.Open(fileName, FileMode.Open));
                input.BaseStream.Seek(18, SeekOrigin.Begin);
                int width = input.ReadInt32();
                int height = input.ReadInt32();
                input.BaseStream.Seek(4, SeekOrigin.Current);
                int compression = input.ReadInt32();
                input.Close();

                Console.WriteLine("Width: " + width);
                Console.WriteLine("Height: " + height);
                Console.WriteLine("Compression: " + compression);
  
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O ERROR: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
    }
}
