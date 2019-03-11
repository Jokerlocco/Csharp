// Gonzalo Arques
using System;
using System.IO;

public class StreamWriter1
{
    public static void Main()
    {
        StreamWriter myFile = File.CreateText("test.txt");
        myFile.WriteLine("Hi!");
        myFile.WriteLine("Bye!");
        myFile.Close();
    }
}
