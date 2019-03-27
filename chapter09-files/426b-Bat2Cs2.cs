//Kevin Marín Romero

using System;
using System.IO;


public class FileTest1
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
            Console.Write("Enter the name of file to copy: ");
            name = Console.ReadLine();
        }

        if (!File.Exists(name))
        {
            Console.WriteLine("File Not Found");
        }
        else
        {
            try
            {
                StreamReader fileIn = File.OpenText(name);
                StreamWriter fileOut = File.CreateText(name + ".cs");

                string line;

                int spaces = 0;

                fileOut.WriteLine("using System;");
                fileOut.WriteLine("using System.IO;");
                fileOut.WriteLine("using System.Diagnostics;");
                fileOut.WriteLine("public class BatFile");
                fileOut.WriteLine("{");
                spaces += 4;
                fileOut.WriteLine(new string(' ', spaces) +
                    "static void Main(string[] args)");
                fileOut.WriteLine(new string(' ', spaces) + "{");
                spaces += 4;
                fileOut.WriteLine(new string(' ', spaces) + "Process proc;");

                do
                {
                    line = fileIn.ReadLine();

                    if (line != null)
                    {
                        string[] data = line.Split();

                        switch (data[0].ToUpper())
                        {
                            case "CLS":
                                fileOut.WriteLine(new string(' ', spaces) +
                                    "System.Console.Clear();");
                                break;
                            case "ECHO":
                                fileOut.WriteLine(new string(' ', spaces) +
                                    "System.Console.WriteLine(\"" +
                                    line.Substring(line.IndexOf(" ")+1) + "\");");
                                break;
                            case "CD":
                                fileOut.WriteLine(new string(' ', spaces) +
                                    "Directory.SetCurrentDirectory(" +
                                    line.Substring(line.IndexOf(" ")+1) + ");");
                                break;
                            default:
                                fileOut.WriteLine(new string(' ', spaces) +
                                    "proc = Process Start(\"" + line
                                    + "\"); proc.WaitForExit();");
                                break;
                        }
                    }
                } while (line != null);
                spaces -= 4;
                fileOut.WriteLine(new string(' ', spaces) + "}");
                fileOut.WriteLine("}");

                fileOut.Close();
                fileIn.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("IO: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}