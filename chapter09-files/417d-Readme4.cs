// Ivan Lazcano Sindin
// Diego Lezcano
// María Gonzalez
using System;
using System.IO;
using System.Threading;

class Less
{
    protected static string[] file;
    protected static int actualLine;
    protected static bool finished;
    protected static bool showHelp = false;

    public static void Search()
    {
        bool found = false;

        Console.Write("Enter search term: ");
        string search = Console.ReadLine();

        for (int i = 0; i < file.Length; i++)
        {
            if (file[i].ToLower().Contains(search.ToLower()) && !found)
            {
                actualLine = i;
                found = true;
            }
        }
    }

    public static void PrintHelp()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("F1 show help");
        Console.WriteLine("Home - start");
        Console.WriteLine("END - bottom");
        Console.WriteLine("Arrow up-down to move");
        Console.WriteLine("Press F to search");
        Console.WriteLine();
        Console.WriteLine("Press 'ESC' to exit");

    }

    public static void UserInput()
    {


        ConsoleKeyInfo k = Console.ReadKey(true);

        if (k.Key == ConsoleKey.UpArrow)
        {
            if (actualLine > 0)
                actualLine--;
        }
        else if (k.Key == ConsoleKey.DownArrow)
        {
            if ((file.Length > actualLine + 23))
                actualLine++;
        }
        else if (k.Key == ConsoleKey.End)
        {
            actualLine = file.Length - 23;
            if (actualLine < 0)
                actualLine = 0;
        }
        else if (k.Key == ConsoleKey.Home)
        {
            actualLine = 0;
        }
        else if (k.Key == ConsoleKey.PageUp)
        {
            actualLine -= 23;
            if (actualLine < 0)
                actualLine = 0;
        }
        else if (k.Key == ConsoleKey.PageDown)
        {
            actualLine += 23;
            if (actualLine >= file.Length)
                actualLine = file.Length - 23;
            if (actualLine < 0)
                actualLine = 0;
        }
        else if (k.Key == ConsoleKey.F1)
            showHelp = true;
        else if (k.Key == ConsoleKey.Escape)
            showHelp = false;
        else if (k.Key == ConsoleKey.F)
        {
            Search();
        }
        else if (k.Key == ConsoleKey.Q)
            finished = true;


    }

    public static void PrintScreen(int line)
    {
        Console.Clear();

        for (int i = line; i < line + 23; i++)
        {
            if (i < file.Length)
                Console.WriteLine(file[i]);
        }
    }

    public static void Main(string[] args)
    {
        actualLine = 0;
        finished = false;
        if (args.Length != 1)
        {
            Console.WriteLine("Need a name");
            return;
        }
        else
        {
            if (!File.Exists(args[0]))
            {
                Console.WriteLine("Wrong name");
            }
            else
            {
                try
                {
                    file = File.ReadAllLines(args[0]);

                    do
                    {
                        if (!showHelp)
                            PrintScreen(actualLine);
                        else
                            PrintHelp();
                        UserInput();
                        Thread.Sleep(60);

                    } while (!finished);

                }
                catch (PathTooLongException)
                {
                    Console.WriteLine("Path to long");
                    return;
                }
                catch (IOException)
                {
                    Console.WriteLine("IOerror");
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                }

            }

        }

    }
}
