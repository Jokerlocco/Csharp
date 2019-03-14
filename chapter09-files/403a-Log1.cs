// Log file
// V1: AppendText

// Javier Benajes

using System;
using System.IO;

class Log
{
    public static void Main()
    {
        StreamWriter fichero = File.AppendText("log.txt");
        Console.Write("Frase: ");
        fichero.WriteLine( Console.ReadLine() );
        fichero.Close();
    }
}
