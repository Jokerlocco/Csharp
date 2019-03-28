//Ivan Lazcano Sindin
using System;
using System.IO;

class Ej
{
    public static void Main(string[] args)
    {

        if (!File.Exists(args[0]))
            Console.WriteLine("Origin does not exist");
        else
        {
            try
            {
                FileStream readFile = File.OpenRead(args[0]);
                readFile.Seek(-128,SeekOrigin.End);
                byte[] header = new byte[128];
                readFile.Read(header, 0, 128);
                string aux = "";
                if(header[0] == 'T' 
                   && header[1] == 'A' 
                   && header[2] == 'G')
                {
                    for (int i = 3; i < 33; i++)
                    {
                        aux += (char)header[i];
                    }
                    Console.WriteLine("Título:" + aux);
                    aux = "";
                    for (int i = 33; i < 63; i++)
                    {
                        aux += (char)header[i];
                    }
                    Console.WriteLine("Artista: " + aux);
                    aux = "";
                    for (int i = 63; i < 93; i++)
                    {
                        aux += (char)header[i];
                    }
                    Console.WriteLine("Álbum: " + aux);
                    aux = "";
                    for (int i = 93; i < 96; i++)
                    {
                        aux += (char)header[i];
                    }
                    Console.WriteLine("Año: " + aux);
                    aux = "";
                    for (int i = 96; i < 126; i++)
                    {
                        aux += (char)header[i];
                    }
                    Console.WriteLine("comentario: " + aux);
                    Console.WriteLine("Género: " + header[127]);
                }
                else
                    Console.WriteLine("no info!");

                readFile.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Name to long");
            }
            catch (IOException)
            {
                Console.WriteLine("IO error");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
