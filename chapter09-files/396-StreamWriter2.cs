// Jorge Calzada Calzada

using System;
using System.IO;

class StreamWriter2
{
    static void Main()
    {
        StreamWriter myFile = new StreamWriter("test2.txt");

        for (int i = 1; i <= 100; i++)
        {
            myFile.WriteLine("Line " + i);
        }

        myFile.Close();
    }
}
