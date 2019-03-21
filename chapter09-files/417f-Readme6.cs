//Kevin Marin Romero
//Jaime Francisco Rebollo Domínguez
//Saul Cánovas Navarro
using System;
using System.IO;
using System.Threading;

public class ReadmeCOM
{
    public static void Main(string[] args)
    {
        string file;
        if (args.Length == 1)
            file = args[0];
        else
        {
            Console.Write("Enter the name of the file: ");
            file = Console.ReadLine();
        }

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found");
        }
        else
        {
            string[] lines = File.ReadAllLines(file);
            bool continuar = true;
            int finalLinea = lines.Length < 24 ? lines.Length : 23;
            int startLine = 0, endLine = finalLinea;

            do
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now + " " + file);
                for (int i = startLine; i < endLine; i++)
                {
                    Console.WriteLine(lines[i]);
                }
                Console.WriteLine("Keys ↑ ↓ PgUp PgDown ESC=Exit F1=HELP");

                ConsoleKeyInfo k = Console.ReadKey(true);
                switch (k.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (endLine < lines.Length)
                        {
                            endLine++;
                            startLine++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (startLine > 0)
                        {
                            endLine--;
                            startLine--;
                        }
                        break;
                    case ConsoleKey.PageDown:
                        endLine += 24;
                        startLine += 24;
                        if (endLine > lines.Length)
                        {
                            endLine = lines.Length;
                            startLine = lines.Length - 24;
                            if (startLine < 0)
                                startLine = 0;
                        }
                        break;
                    case ConsoleKey.PageUp:
                        endLine -= 24;
                        startLine -= 24;
                        if (startLine < 0)
                        {
                            endLine = finalLinea;
                            startLine = 0;
                        }
                        break;
                    case ConsoleKey.End:
                        endLine = lines.Length;
                        startLine = lines.Length - 24;
                        if (startLine < 0)
                            startLine = 0;
                        break;
                    case ConsoleKey.Home:
                        endLine = finalLinea;
                        startLine = 0;
                        break;
                    case ConsoleKey.F1:
                        Console.Clear();
                        Console.WriteLine(DateTime.Now + " " + file);
                        Console.WriteLine("F Find Text");
                        Console.WriteLine("↑ Go up");
                        Console.WriteLine("↓ Go down");
                        Console.WriteLine("AvPag Show next 24 lines");
                        Console.WriteLine("RePag Show previous 24 lines");
                        Console.WriteLine("ESC Exit");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.F:
                        Console.Write("FIND: ");
                        string search = Console.ReadLine();
                        bool found = false;
                            int i = 0;
                        if (lines.Length > 24)
                        {
                            while (!found && i < lines.Length)
                            {
                                if (lines[i].Contains(search))
                                {
                                    startLine = i;
                                    endLine = 23 + i;
                                    if (endLine > lines.Length)
                                        endLine = lines.Length;
                                    found = true;
                                }
                                i++;
                            }
                        }
                    break;
                    case ConsoleKey.Escape:
                        continuar = false;
                        break;
                }
                
                Thread.Sleep(100);
            } while (continuar);

        }
    }
}
