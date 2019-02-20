//Pablo Sánchez Alonso
using System;
using System.Collections;

class DictionarySortedList
{

    public static void Main()
    {
        SortedList diccionario = new SortedList();
        diccionario.Add("hello", "hola");
        diccionario.Add("table", "mesa");
        diccionario.Add("window", "ventana");
        diccionario.Add("dog", "perro");
        diccionario.Add("cat", "gato");
        diccionario.Add("horse", "caballo");
        diccionario.Add("sister", "hermana");
        diccionario.Add("brother", "hermano");
        diccionario.Add("father", "padre");
        diccionario.Add("mother", "madre");

        string palabra;
        do
        {
            Console.WriteLine("Introduce una palabra");
            palabra = Console.ReadLine();

            if (palabra != "")
            {
                if (diccionario.Contains(palabra))
                {
                    Console.WriteLine(diccionario[palabra]);
                }
                else
                {
                    Console.WriteLine("Palabra no encontrada");
                }
            }
        } while (palabra != "");
    }
}

