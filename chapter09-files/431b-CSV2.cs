// CSV, version 2 (also simplified: no File.Exists nor try..catch)
// Uses "replace" to obtain fragments

/*
Input sample:

"Juan";"López Pérez";"Alicante";25
"Antonio";"Pérez López";"Madrid";27

Output sample:

Juan
López Pérez
Alicante
25

Antonio
Pérez López
Madrid
27

*/

using System;
using System.IO;

public class CSV2
{
    public static void Main(string[] args)
    {
        string fileName = "data.csv";

        StreamReader input = new StreamReader(fileName);
        StreamWriter output = new StreamWriter(fileName + ".txt");

        string line;
        do
        {
            line = input.ReadLine();
            if (line != null)
            {
                line = line.Replace("\"","");
                output.WriteLine( line.Replace(";","\n") );
                output.WriteLine( );
            }
        }
        while (line != null);
        input.Close();
        output.Close();
    }
}
