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
        diccionario.Add("good bye", "adi�s");
        diccionario.Add("dog", "perro");
        diccionario.Add("cat", "gato");
        diccionario.Add("bird", "p�jaro");
        diccionario.Add("table", "mesa");
        diccionario.Add("chair", "silla");
        diccionario.Add("mouse", "rat�n");
        diccionario.Add("keyboard", "teclado");
        diccionario.Add("window", "ventana");

        Console.Write("Palabra: ");
        string palabra = Console.ReadLine().ToLower();

        if (diccionario.ContainsKey(palabra))
            Console.WriteLine(diccionario[palabra]);
        else
            Console.WriteLine("Esa palabra no est� en el diccionario.");
    }
}
