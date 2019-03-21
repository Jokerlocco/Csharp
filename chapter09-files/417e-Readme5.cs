// Gonzalo Arques, Manuel Lago, Jose Vicente Anton
using System;
using System.IO;

public class More
{
    public static void Main(string[] args)
    {
        string fileName;

        if (args.Length < 1)
        {
            Console.WriteLine("Enter file name: ");
            fileName = Console.ReadLine();
        }
        else
        {
            fileName = args[0];
        }

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist");
        }

        else
        {
            try
            {
                string[] file = File.ReadAllLines(fileName);
                int firstIndex = 0;
                int lastIndex = 25;

                do
                {
                    Console.Clear();
                    for(int i= firstIndex; i < firstIndex+25; i++)
                    {
                        if(i >= 0 && i < file.Length)
                        {
                            Console.WriteLine(file[i]);
                        }
                        
                    }

                    ConsoleKeyInfo key = Console.ReadKey();
                    if(key.Key == ConsoleKey.UpArrow 
                        && firstIndex > 0)
                    {
                        firstIndex--;
                        lastIndex--;
                    }
                    if (key.Key == ConsoleKey.DownArrow
                        && lastIndex < file.Length)
                    {
                        firstIndex++;
                        lastIndex++;
                    }
                    if (key.Key == ConsoleKey.PageUp
                        && firstIndex > 0)
                    {
                        if(firstIndex < 25)
                        {
                            firstIndex -= firstIndex;
                            lastIndex -= firstIndex;
                        }
                        else
                        {
                            firstIndex -= 25;
                            lastIndex -= 25;
                        }
                        
                    }
                    if (key.Key == ConsoleKey.PageDown
                        && lastIndex < file.Length)
                    {
                        if (firstIndex < 25)
                        {
                            firstIndex += file.Length - lastIndex;
                            lastIndex += file.Length - lastIndex;
                            
                        }
                        else
                        {
                            firstIndex += 25;
                            lastIndex += 25;
                        }
                       
                    }
                    if (key.Key == ConsoleKey.End
                        && firstIndex > 0)
                    {
                        firstIndex = 0;
                        lastIndex = 25;
                    }
                    if (key.Key == ConsoleKey.Home
                        && lastIndex < file.Length)
                    {
                        firstIndex = file.Length-26;
                        lastIndex = file.Length-1;
                    }
                    if (key.Key == ConsoleKey.F)
                    {
                        Console.Write("Find: ");
                        string palabra = Console.ReadLine();
                        bool control = false;
                        
                        for(int i=0; i < file.Length; i++)
                        {
                            if(file[i].Contains(palabra) 
                                && control )
                            {
                                firstIndex = i;
                                lastIndex = i + 25;

                            }
                        }
                    }
                    if (key.Key == ConsoleKey.F1)
                    {
                        Console.Clear();
                        Console.WriteLine("README.COM 2.03 help screen");
                        Console.WriteLine("Copyright (c) 1986, " +
                            "1989 Borland International");
                        Console.WriteLine("F Find text");
                        Console.WriteLine("N Find next");
                        Console.WriteLine("Home Start of files ");
                        Console.WriteLine("End End of file");
                        Console.WriteLine("W Wrap long lines on/off");
                        while(!Console.KeyAvailable)
                        {

                        }
                        
                    }
                }
                while(true);
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}