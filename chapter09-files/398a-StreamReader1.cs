// Manuel Lago

using System;
using System.IO;

class ReadFile
{
    public static void Main()
    {
        Console.WriteLine("File name");
        string name = Console.ReadLine();
        
        StreamReader file = File.OpenText(name +".cs");
        
        string line = file.ReadLine();
        while( line != null)
        {
            if(line != null)
            {
                line = line.Trim();
                if(line.Length > 0)
                {
                    Console.WriteLine(line);
                }
            }
            line = file.ReadLine();
        }
        
        file.Close();
    }
}
