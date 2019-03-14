// Manuel Lago

using System;
using System.IO;

class OtherFolder
{   
    static void Main()
    {
        StreamReader file = 
            new StreamReader(@"..\..\MyProject.csproj");

        string line = file.ReadLine();
        while(line != null)
        {
            if(line != null)
            {
                Console.WriteLine(line);
            }

            line = file.ReadLine();
        }
        file.Close();
    }
}

