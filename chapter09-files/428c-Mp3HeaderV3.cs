// José Vicente Antón Castelló

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Número inválido de argumentos");
        }
        else
        {
            string path = args[0];

            if (File.Exists(path))
            {
                try
                {
                    FileStream fileIn =
                            File.Open(path, FileMode.Open);

                    fileIn.Seek(-128, SeekOrigin.End);

                    if (!(fileIn.ReadByte() == 'T'
                        && fileIn.ReadByte() == 'A'
                        && fileIn.ReadByte() == 'G'))
                    {
                        Console.WriteLine("No parece un MP3 válido");
                    }
                    else
                    {
                        Console.Write("Título: ");

                        byte current;

                        for (int i = 0; i < 30; i++)
                        {
                            current = (byte)fileIn.ReadByte();
                            Console.Write(current < 32 ? " "
                                : Convert.ToChar(current).ToString());
                        }

                        Console.WriteLine();
                        Console.Write("Artista: ");

                        for (int i = 0; i < 30; i++)
                        {
                            current = (byte)fileIn.ReadByte();
                            Console.Write(current < 32 ? " "
                                : Convert.ToChar(current).ToString());
                        }

                        Console.WriteLine();
                        Console.Write("Álbum: ");

                        for (int i = 0; i < 30; i++)
                        {
                            current = (byte)fileIn.ReadByte();
                            Console.Write(current < 32 ? " "
                                : Convert.ToChar(current).ToString());
                        }

                        Console.WriteLine();
                        Console.Write("Año: ");

                        for (int i = 0; i < 4; i++)
                        {
                            current = (byte)fileIn.ReadByte();
                            Console.Write(current < 32 ? " "
                                : Convert.ToChar(current).ToString());
                        }

                        Console.WriteLine();
                        Console.Write("Comentario: ");

                        for (int i = 0; i < 30; i++)
                        {
                            current = (byte)fileIn.ReadByte();
                            Console.Write(current < 32 ? ' '
                                : (char) current);
                        }

                        Console.WriteLine();
                        Console.Write("Género: ");

                        Console.Write(fileIn.ReadByte());
                    }

                    fileIn.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine("I/O Error" + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error" + e.Message);
                }
            }
        }
    }
}

