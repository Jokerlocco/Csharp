// Count lines, words, characters
// Javier Benajes

using System;
using System.IO;
using System.Collections.Generic;

class WC
{
    public static void Main(string[] args)
    {
        if (args.Length == 1)
        {
            StreamReader f = new StreamReader(args[0] + ".txt");

            List<string> palabras = new List<string>();
            int contadorLineas = 0;
            int contadorPalabras = 0;
            int contadorLetras = 0;

            string linea;

            do
            {
                linea = f.ReadLine();

                if (linea != null)
                {
                    if (linea.Length > 0)
                    {
                        contadorLineas++;
                    }

                    string[] palabrasEnLinea = linea.Split();
                    foreach (string p in palabrasEnLinea)
                    {
                        if (p != "")
                            contadorPalabras++;
                    }

                    contadorLetras += linea.Length;
                }
            } while (linea != null);

            f.Close();

            Console.WriteLine("En el fichero " + "\"" + args[0] 
                + ".txt" + "\" hay " + contadorLineas + " líneas, " 
                + contadorPalabras + " palabras y " 
                + contadorLetras + " letras.");
        }
    }
}
