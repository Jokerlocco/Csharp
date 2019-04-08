//Ivan Lazcano Sindin
using System;
using System.IO;

class FilesInTheCurrentDirectory2
{
    public static void Main(string[] args)
    {
        string dir = ".";
        string[] files = Directory.GetFiles(dir, "*.cs");

        foreach(string s in files)
        {
            Console.WriteLine(s);
        }
    }
}
