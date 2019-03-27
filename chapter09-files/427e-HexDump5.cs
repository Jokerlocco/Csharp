// Kevin Marín Romero

using System;
using System.IO;

public class HexDump
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
            Console.Write("Enter the name of file to dump: ");
            name = Console.ReadLine();
        }

        if(!File.Exists(name))
        {
            Console.WriteLine("File Not Found");
        }
        else
        {
            try
            {
                FileStream fileIn = File.OpenRead(name);
                string hex = "";
                string simbols = "";

                const byte SIZE = 16;

                byte[] data;

                int lineSize;

                do
                {
                    data = new byte[SIZE];
                    lineSize = fileIn.Read(data,0,SIZE);

                    for (int i = 0; i < lineSize; i++)
                    {
                        string h = data[i].ToString("X2");
                        hex += h + " ";

                        simbols += data[i] < 32 ? "." : 
                            Convert.ToChar(
                            Convert.ToInt32(h, 16)).ToString();
                    }
                    
                    if (lineSize < SIZE)
                    {
                        for (int i = lineSize; i < SIZE; i++)
                        {
                            hex += "   ";
                            simbols += " ";
                        }
                    }
                   
                } while (lineSize == SIZE);

                fileIn.Close();

                while (hex.Length > 0)
                {
                    Console.WriteLine(
                        hex.Substring(0, hex.Length > 48 ? 48 : hex.Length) +
                        " " + simbols.Substring(0, 
                        simbols.Length > 16 ? 16 : simbols.Length));
                    hex = hex.Remove(0, hex.Length > 48 ? 48 : hex.Length);
                    simbols = simbols.Remove(0, 
                        simbols.Length > 16 ? 16 : simbols.Length);
                }

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
