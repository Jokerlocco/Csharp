// Enumerator for a Hashtable

using System;
using System.Collections;

public class HashtableEnumerator
{
    public static void Main()
    {
        Hashtable myDictionary = new Hashtable();
        myDictionary.Add("hoygan", "oigan");
        myDictionary.Add("porfabor", "por favor");
        myDictionary.Add("nesecito", "necesito");
        myDictionary.Add("alluda", "ayuda");
        myDictionary.Add("alludar", "ayudar");
        myDictionary.Add("grasias", "gracias");
        myDictionary.Add("ejersisio", "ejercicio");

        IDictionaryEnumerator myEnumerator =
            myDictionary.GetEnumerator();
        while (myEnumerator.MoveNext())
        {
            Console.WriteLine(myEnumerator.Key + " -> " +
                myEnumerator.Value);
        }
    }
}
