// Adrián Navarro Gabino

using System;
using System.Diagnostics;

class LaunchProcess3
{
    static void Main()
    {
        int pass = -1;
        
        Process proc;
        ProcessStartInfo procInfo;
        
        do
        {
            pass++;
            Console.Write(pass+" ");
            procInfo = new ProcessStartInfo("7za.exe", 
                "x -p" + pass.ToString("0000") +" c.7z");
            procInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc = Process.Start(procInfo);
            proc.WaitForExit();
            
            if(proc.ExitCode == 0)
                Console.WriteLine("Found!");
            
        } while(proc.ExitCode != 0);
        
        Console.WriteLine(pass.ToString("0000"));
    }
}
