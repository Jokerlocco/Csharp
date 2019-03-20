// Valid EXE File?
// Javier Benajes

using System;
using System.IO;

class FicheroBinario
{
    public static void Main()
    {
        Console.Write("File name: ");
        string name = Console.ReadLine();

        FileStream file = File.OpenRead(name);
        byte firstByte = (byte)file.ReadByte();
        byte secondByte = (byte)file.ReadByte();
        file.Close();

        char firstData = Convert.ToChar(firstByte);
        char secondData = Convert.ToChar(secondByte);

        if (firstData == 'M' && secondData == 'Z')
            Console.WriteLine("It seems a valid EXE file.");
        else
            Console.WriteLine("It is not a valid EXE file.");
    }
}
