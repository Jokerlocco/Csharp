//Pablo Sánchez Alonso
using System;
using System.IO;

class ReadFile2
{
    public static void Main()
    {
        StreamReader file = new StreamReader("395.cs");
        string line;

        do
        {
            line = file.ReadLine();

            if(line != null)
            {
                
                Console.WriteLine(line.Replace("WriteLine", "printf"));
            }

        } while (line != null);

        file.Close();
    }
}
