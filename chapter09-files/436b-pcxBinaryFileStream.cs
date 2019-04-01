using System;
using System.IO;

public class PcxViewer2
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
                FileStream file = File.OpenRead(name);
                int size = (int) file.Length;
                byte[] data = new byte[size];
                int sizeRead = file.Read(data, 0, size);
                file.Close();

                if (size != sizeRead)
                {
                    Console.WriteLine("Read error");
                    return;
                }

                byte mark = data[0];
                if (mark != 10)
                {
                    Console.WriteLine("It is not a PCX file");
                    return;
                }

                byte compression = data[2];
                if (compression != 1)
                {
                    Console.WriteLine("Image is not compressed");
                    return;
                }

                byte bitsPerPixel = data[3];
                if (bitsPerPixel != 8)
                {
                    Console.WriteLine("Image is not 256 colors");
                    return;
                }

                short xMin = (short) (data[4] + 256*data[5]);
                short yMin = (short) (data[6] + 256*data[7]);
                short xMax = (short) (data[8] + 256*data[9]);
                short yMax = (short) (data[10] + 256*data[11]);

                int width = xMax - xMin + 1;
                int height = yMax - yMin + 1;

                byte bytesPerLine = data[66];
                if (bytesPerLine != width)
                {
                    Console.WriteLine("Incorrect bytes per line");
                    return;
                }

                // Let's read the image data
                string imageData = "";
                int pos = 128;
                while(pos < data.Length - 1)
                {
                    byte pixel = data[pos++];
                    if (pixel < 192)
                        imageData += PixelToDraw(pixel);
                    else
                    {
                        byte repetitions = (byte) (pixel - 192);
                        pixel = data[pos++];
                        for (int p = 0; p < repetitions; p++)
                        {
                            imageData += PixelToDraw(pixel);
                        }
                    }
                }

                // And finally let's draw it
                int drawPos = 0;
                for (int row = 0; row < height; row++)
                {
                    for (int column = 0; column < width; column++)
                    {
                        Console.Write(imageData[drawPos]);
                        drawPos++;
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
