using System;
using System.IO;

public class PcxViewer1
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
            Console.Write("Enter the PCX file name: ");
            name = Console.ReadLine();
        }

        if (!File.Exists(name))
        {
            Console.WriteLine("File not found");
        }
        else
        {
            try
            {
                BinaryReader file = new BinaryReader(
                    File.Open(name, FileMode.Open));
                byte mark = file.ReadByte();
                if (mark != 10)
                {
                    Console.WriteLine("It is not a PCX file");
                    return;
                }

                file.BaseStream.Seek(2, SeekOrigin.Begin);
                byte compression = file.ReadByte();
                if (compression != 1)
                {
                    Console.WriteLine("Image is not compressed");
                    return;
                }

                byte bitsPerPixel = file.ReadByte();
                if (bitsPerPixel != 8)
                {
                    Console.WriteLine("Image is not 256 colors");
                    return;
                }

                short xMin = file.ReadInt16();
                short yMin = file.ReadInt16();
                short xMax = file.ReadInt16();
                short yMax = file.ReadInt16();

                int width = xMax - xMin + 1;
                int height = yMax - yMin + 1;

                file.BaseStream.Seek(66, SeekOrigin.Begin);
                byte bytesPerLine = file.ReadByte();
                if (bytesPerLine != width)
                {
                    Console.WriteLine("Incorrect bytes per line");
                    return;
                }

                // Let's read the image data
                file.BaseStream.Seek(128, SeekOrigin.Begin);
                string imageData = "";
                while(file.BaseStream.Position < file.BaseStream.Length-1)
                {
                    byte data = file.ReadByte();
                    if (data < 192)
                        imageData += PixelToDraw(data);
                    else
                    {
                        byte repetitions = (byte) (data - 192);
                        data = file.ReadByte();
                        for (int p = 0; p < repetitions; p++)
                        {
                            imageData += PixelToDraw(data);
                        }
                    }
                }

                file.Close();

                // And finally let's draw it
                int pos = 0;
                for (int row = 0; row < height; row++)
                {
                    for (int column = 0; column < width; column++)
                    {
                        Console.Write(imageData[pos]);
                        pos++;
                    }
                    Console.WriteLine();
                }

            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
        }
    }

    static char PixelToDraw(byte color)
    {
        if (color > 200) return ' ';
        else if (color >= 150) return '.';
        else if (color >= 100) return '.';
        else if (color >= 50) return '=';
        else return '#';
    }
}
