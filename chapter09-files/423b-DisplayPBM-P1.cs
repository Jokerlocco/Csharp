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
                StreamReader image = new StreamReader(args[0]);

                string aux = image.ReadLine();
                if(aux != null && aux == "P1")
                {
                    aux = image.ReadLine();
                    if(aux[0] == '#')
                        aux = image.ReadLine();
                    int width = Convert.ToInt32(aux.Split()[0]);
                    int actual = 0;
                    aux = image.ReadLine();
                    while(aux != null)
                    {
                        for (int i = 0; i < aux.Length; i++)
                        {
                            if (aux[i] == '1')
                                Console.Write("#");
                            else if (aux[i] == '0')
                                Console.Write("·");
                            else
                                actual--;
                            actual++;

                            if (actual >= width)
                            {
                                Console.WriteLine();
                                actual = 0;
                            }
                        }
                        aux = image.ReadLine();
                    }
                }
                else
                    Console.WriteLine("Wrong format");
            }
            catch(PathTooLongException)
            {
                Console.WriteLine("Name to long");
            }
            catch (IOException)
            {
                Console.WriteLine("IO error");
            }
            catch (Exception)
            {
                Console.WriteLine("Error on file!");
            }
        }
    }
}
