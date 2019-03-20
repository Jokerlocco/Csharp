// María González Martínez

using System;
using System.IO;

class ExtractTextFromBinaryFile
{
    static void Main()
    {
        Console.Write("File name? ");
        string name = Console.ReadLine();
        
        FileStream file = new FileStream(name, FileMode.Open);        
        StreamWriter fichero2 = File.CreateText(name + ".txt");
        
        for (int i = 0; i < file.Length; i++)
        {
            byte data = (byte) file.ReadByte();
            if((data >= 32 && data <= 126) 
                || data == 9 || data == 10 || data == 13)
            {
                char caracter = Convert.ToChar(data);
                fichero2.Write(caracter);
            }
        }
        
        fichero2.Close();
        file.Close();
    }
}
