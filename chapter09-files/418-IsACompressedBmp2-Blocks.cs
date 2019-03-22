// Adrián Navarro Gabino

using System;
using System.IO;

class IsACompressedBmp2
{
    static void Main()
    {
        int headerSize = 54;
        byte[] data = new byte[headerSize];
        
        Console.Write("Filename: ");
        FileStream file = new FileStream(
            Console.ReadLine(), FileMode.Open);
        int bytesRead = file.Read(data, 0, headerSize);        
        file.Close();
        
        if(bytesRead != headerSize)
            Console.WriteLine("Error reading the file");
        else
        {
            if(data[0] == 'B' && data[1] == 'M')
            {
                Console.WriteLine("It seems a valid bmp file");
                
                if(data[30] == 0)
                    Console.WriteLine("The bmp isn't compressed");
                else
                    Console.WriteLine("The bmp is compressed");
            }
            else
                Console.WriteLine("It's NOT a bmp file");
        }
    }
}
