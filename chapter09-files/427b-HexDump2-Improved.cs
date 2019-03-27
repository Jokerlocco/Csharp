/*

Crea un visor hexadecimal (dump.exe), según los siguientes requisitos:
recibirá un nombre de fichero como parámetro, y mostrará cada 16 bytes
como secuencia de dos cifras en hexadecimal y luego como caracteres
(los caracteres cuyo código ASCII sea inferior a 32 no se mostrarán,
sino que en su lugar se mostrará un punto), como en el siguiente
ejemplo:

00 00 00 00 64 00 00 00 28 00 00 00 28 00 00 00 ....d...(...(...
47 58 44 42 41 53 45 43 A0 0F 00 00 00 00 00 00 GXDBASEC........
00 00 00 00 00 00 00 00 FE FE 00 00 3C 00 00 00 ............<...
4E 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 N...............
00 00 00 00 4D 6F 75 73 65 00 00 00 00 00 00 00 ....Mouse.......
00 00 00 00 44 00 00 00 40 9F 40 67 6C 8B 43 96 ....D...@.@gl.C.
00 00 ..

(La última también se debe mostrar correctamente formateada, aunque
contenga menos de 16 bytes).

Nota: se puede convertir un byte a hexadecimal con:
"Convert.ToString(data, 16);" o con "dato.ToString("x2");"

*/

using System;
using System.IO;

public class HexadecimalFileViewer
{
    public static void Main(string[] args)
    {
        string fileName;
        if (args.Length > 0)
            fileName = args[0];
        else
        {
            Console.Write("Enter the filename: ");
            fileName = Console.ReadLine();
        }

        if (!File.Exists(fileName) )
        {
            Console.WriteLine("The file doesn't exist");
        }
        else
        {
            FileStream file = File.OpenRead(fileName);
            int blockSize = 16;
            byte[] data = new byte[blockSize];

            int readBytes;
            int address = 0;
            do
            {
                // Current address
                Console.Write(address.ToString("x8")+ "   ");

                // Hex data
                readBytes = file.Read(data, 0, blockSize);
                for(int i = 0 ; i < readBytes ; i++)
                {
                    Console.Write(data[i].ToString("x2")+ " ");
                }

                // If last line is shorter than 16, we must align
                for(int i = readBytes ; i < 16 ; i++)
                {
                    Console.Write( "   " );
                }

                // ASCII data
                for(int i = 0 ; i < readBytes ; i++)
                {
                    if (data[i] < 32)
                        Console.Write( '.');
                    else
                        Console.Write( (char) data[i] );
                }

                Console.WriteLine();
                address += 16;
            }
            while (readBytes == blockSize);

            file.Close();
        }
    }
}
