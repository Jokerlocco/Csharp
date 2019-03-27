// Jorge Calzada Asenjo

using System;
using System.IO;

public class Dump
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
            Console.Write("Write the path of the file: ");
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
                FileStream file = File.OpenRead(path);
                int size = (int)file.Length;
                byte[] data = new byte[size];
                int sizeRead = file.Read(data, 0, size);
                file.Close();

                if (size != sizeRead)
                {
                    Console.WriteLine("Reading error");
                }
                else
                {
                    int line = 0;
                    bool finished = false;

                    do
                    {
                        int start = line*16;
                        int end = start + 16;
                        for (int j = start; j < end; j++)
                        {
                            if (j < data.Length)
                            {
                                Console.Write(Convert.ToString(data[j], 16)
                                    .PadLeft(2,'0') + " ");
                            }
                            else
                            {
                                Console.Write("   ");
                                finished = true;
                            }
                        }

                        for (int j = start; j < end; j++)
                        {
                            if (j < data.Length)
                            {
                                if (data[j] < 32)
                                {
                                    Console.Write(".");
                                }
                                else
                                {
                                    Console.Write(Convert.ToChar(data[j]));
                                }
                            }
                        }

                        Console.WriteLine();
                        line++;
                    } while (!finished);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("The file can not read");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
