// Javier Benajes

using System;
using System.Collections.Generic;

class DictionaryStringString
{
    public static void Main()
    {
        Dictionary<string, string> diccionario = 
            new Dictionary<string, string>();

        diccionario.Add("hello", "hola");
        diccionario.Add("good bye", "adiós");
        diccionario.Add("dog", "perro");
        diccionario.Add("cat", "gato");
        diccionario.Add("bird", "pájaro");
        diccionario.Add("table", "mesa");
        diccionario.Add("chair", "silla");
        diccionario.Add("mouse", "ratón");
        diccionario.Add("keyboard", "teclado");
        diccionario.Add("window", "ventana");

        Console.Write("Palabra: ");
        string palabra = Console.ReadLine().ToLower();

        if (diccionario.ContainsKey(palabra))
            Console.WriteLine(diccionario[palabra]);
        else
            Console.WriteLine("Esa palabra no está en el diccionario.");
    }
}
