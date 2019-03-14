// Log + DateTime
// Javier Benajes

using System;
using System.IO;

class LogDatetime
{
    public static void Main()
    {
        StreamWriter fichero = File.AppendText("log.txt");
        string frase;
        Console.Write("Frase: ");
        frase = Console.ReadLine();
        fichero.WriteLine(DateTime.Now + " " + frase);
        fichero.Close();
    }
}
