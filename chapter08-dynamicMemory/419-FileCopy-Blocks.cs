//Ivan Lazcano Sindin
using System;
using System.IO;

class FileCopyBlocks
{
    public static void Main(string[] args)
    {
        if (args.Length < 2)
            Console.WriteLine("Please specify source and destination");
        else if(!File.Exists(args[0]))
            Console.WriteLine("Origin does not exist");
        else
            try
            {
                FileStream readFile = File.OpenRead(args[0]);
                int size = (int) readFile.Length;
                byte[] data = new byte[size];
                readFile.Read(data, 0, size);
                readFile.Close();

                if(File.Exists(args[1]))
                    Console.WriteLine("File exists...");
                else
                {
                    FileStream writeFile = File.Create(args[1]);
                    writeFile.Write(data, 0, size);
                    writeFile.Close();
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("Error on file!");
            }

    }
}
