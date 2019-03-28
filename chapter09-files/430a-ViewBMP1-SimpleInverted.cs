//Ivan Lazcano Sindin
using System;
using System.IO;

class Ej
{
    public static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            if (!File.Exists(args[0]))
                Console.WriteLine("Origin does not exist");
            else
            {
                try
                {
                    BinaryReader img = new BinaryReader(
                        File.Open(args[0], FileMode.Open));

                    img.BaseStream.Seek(10, 0);
                    int posData = img.ReadInt32();
                    img.BaseStream.Seek(18, 0);
                    int width = img.ReadInt32();
                    int height = img.ReadInt32();
                    img.BaseStream.Seek(posData,0);

                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (img.ReadByte() > 127)
                                Console.Write(".");
                            else
                                Console.Write("#");
                        }
                        Console.WriteLine();
                    }

                    img.Close();
                }
                catch (PathTooLongException)
                {
                    Console.WriteLine("Name to long");
                }
                catch (IOException)
                {
                    Console.WriteLine("IO error");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
