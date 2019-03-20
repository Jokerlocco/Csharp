// Is a valid PNG file?
// Jorge Calzada Asenjo

using System;
using System.IO;

class Fichero2
{
    static void Main(string[] args)
    {
        string path;

        if (args.Length == 0)
        {
            Console.Write("Enter the path: ");
            path = Console.ReadLine();
        }
        else
        {
            path = args[0];
        }

        if (!path.ToLower().EndsWith(".png"))
        {
            Console.WriteLine("File extension is not .png");
        }
        else
        {
            if (File.Exists(path))
            {
                try
                {
                    FileStream file = 
                        new FileStream(path, FileMode.Open);
                    file.ReadByte();
                    byte first = (byte)file.ReadByte();
                    byte second = (byte)file.ReadByte();
                    byte third = (byte)file.ReadByte();
                    file.Close();

                    if (first == 'P' && second == 'N' 
                        && third == 'G')
                    {
                        Console.WriteLine("It seems a valid .png file");
                    }
                    else
                    {
                        Console.WriteLine("It is NOT a valid .png file");
                    }
                    
                }
                catch (IOException)
                {
                    Console.WriteLine("Read error");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }

    }
}
