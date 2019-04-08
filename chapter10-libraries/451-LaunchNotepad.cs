using System;
using System.Diagnostics;

class NotepadLauncher
{
    public static void Main()
    {
        Process proc = Process.Start("notepad.exe");
        proc.WaitForExit();
    }
}
