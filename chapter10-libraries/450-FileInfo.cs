// Adrián Navarro Gabino

using System;
using System.IO;

class FilesInfoCurrentDirectory
{
    static void Main()
    {
        DirectoryInfo dir = new DirectoryInfo(".");
        
        FileInfo[] files = dir.GetFiles();
        
        foreach(FileInfo file in files)
            if(file.Name.EndsWith(".cs") ||
                    file.Name.EndsWith(".exe"))
                Console.WriteLine(file.Name + " - " + 
                    (file.Length / 1024.0).ToString("N2") + 
                    " KB");
    }
}
