//Ivan Lazcano Sindin
using System;
using System.IO;

class FilesInTheCurrentDirectory
{
    public static void Main(string[] args)
    {
        string dir = ".";
        string[] files = Directory.GetFiles(dir);

        foreach(string s in files)
        {
            if(s.EndsWith(".cs"))
                Console.WriteLine(s);
        }
    }
}
