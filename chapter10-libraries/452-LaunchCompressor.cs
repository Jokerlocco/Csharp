// Javier Benajes

using System;
using System.Diagnostics;

class LaunchCompressor
{
    public static void Main()
    {
        Process proc = Process.Start("7za.exe", "a fuentes *.cs");
        proc.WaitForExit();
        if (proc.ExitCode == 0)
        {
            Console.WriteLine("Compression successful");
        }
        else
        {
            Console.WriteLine("Compression unsuccessful");
        }
    }
}
