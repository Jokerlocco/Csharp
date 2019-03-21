// Daniel Contreras
// Araceli Yañez
// Jorge Calzada

using System;
using System.IO;

class Readme
{
    static void Move(string[] text)
    {
        bool exit = false;
        int position = 0;

        do
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (position > 0)
                    {
                        position--;
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (position + 23 < text.Length)
                    {
                        position++;
                    }
                }
                else if (key.Key == ConsoleKey.PageUp)
                {
                    if (position - 23 > 0)
                    {
                        position -= 23;
                    }
                    else
                    {
                        position = 0;
                    }
                }
                else if (key.Key == ConsoleKey.PageDown || key.Key == ConsoleKey.Enter)
                {
                    if (position + 46 < text.Length)
                    {
                        position += 23;
                    }
                    else
                    {
                        position = text.Length - 23;
                    }
                }
                else if (key.Key == ConsoleKey.Home)
                {
                    position = 0;
                }
                else if (key.Key == ConsoleKey.End)
                {
                    if (position - 23 > 0)
                    {
                        position = position - 23;
                    }
                    else
                    {
                        position = 0;
                    }
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    exit = true;
                }

                Draw(text, position);
            }
        } while (!exit);
    }

    static void Draw (string[] text, int position)
    {
        Console.Clear();

        if (text.Length < 24)
        {
            for (int i = position; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
            for (int i = text.Length; i < 24; i++)
            {
                Console.WriteLine();
            }
        }
        else
        {
            for (int i = position; i < 23; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }

    static void Main(string[] args)
    {
        string path;

        if (args.Length == 0)
        {
            Console.Write("Enter the path to the file: ");
            path = Console.ReadLine();
        }
        else
        {
            path = args[0];
        }

        if (File.Exists(path))
        {
            try
            {
                string[] lines = File.ReadAllLines(path);

                Draw(lines, 0);

                while (true)
                {
                    Move(lines);
                }

            }
            catch (IOException)
            {
                Console.WriteLine("Reading error");
            }
            catch (Exception)
            {
                Console.WriteLine("Other error");
            }
        }
        else
        {
            Console.WriteLine("The file does not exist or the path is incorrect");
        }

    }
}
