using System;
using System.IO;

class ReadFile2
{
    public static void Main()
    {
        Console.WriteLine("File name");
        string name = Console.ReadLine();
        
        StreamReader file = File.OpenText(name +".cs");
        
        string line = file.ReadLine();
        do
        {
            line = file.ReadLine();
            if(line != null)
            {
                line = line.Trim();
                if(line.Length > 0)
                {
                    Console.WriteLine(line);
                }
            }
        }
        while( line != null);        
        file.Close();
    }
}
