using System;
using System.IO;
using System.Collections.Generic;

//Javi, Pablo, Miguel

class MsDOS
{
    static void Main(string[] args)
    {
        List<string> datos = new List<string>();
        StreamReader fichero = new StreamReader("datos.txt");
        StreamReader ayuda = new StreamReader("ayuda.txt");
        string linea;
        int cont = 0;
        int cont2 = 0;
        ConsoleKeyInfo k;

        do
        {

            linea = fichero.ReadLine();
            if (linea != null && cont < 22)
            {
                Console.WriteLine(linea);
                cont++;
                cont2++;
                datos.Add(linea);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                k = Console.ReadKey(true);
                do
                {

                
                    if (k.Key == ConsoleKey.UpArrow)
                    {
                        Console.Clear();
                        cont2--;
                        for (int i = cont2 - 2; i < cont2; i++)
                        {
                            Console.WriteLine(datos[i]);
                        }
                    }
                    else if(k.Key == ConsoleKey.DownArrow)
                    {
                        Console.WriteLine(linea);
                    }
                    else if (k.Key == ConsoleKey.H)
                    {
                        string lineaAyuda;
                        Console.Clear();
                        do
                        {
                            lineaAyuda = ayuda.ReadLine();
                            if (lineaAyuda != null)
                            {
                                Console.WriteLine(lineaAyuda);
                            }

                        } while (lineaAyuda != null);
                    }

                } while (k.Key != ConsoleKey.Enter);
                cont = 0;
            }
        } while (linea != null);

    }
}

