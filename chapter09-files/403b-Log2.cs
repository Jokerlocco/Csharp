// Log file
// V2: Constructor

// Javier Benajes

using System;
using System.IO;

class Log
{
    public static void Main()
    {
        StreamWriter fichero = new StreamWriter("log.txt", true);
        Console.Write("Frase: ");
        fichero.WriteLine( Console.ReadLine() );
        fichero.Close();
    }
}
