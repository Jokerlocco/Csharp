/*
134 - 26 Oct A - Bucles, examen 2017
Crea un ÚNICO programa en C# que muestre en pantalla los números que hay
entre dos números introducidos por el usuario excepto el 0, todos ellos 
en una misma línea y separados por un espacio en blanco, avanzando de 
línea tras escribir todos ellos. Los números se escribirán ascendiendo 
si el segundo número es mayor que el primero, o descendiendo si el 
segundo número es el menor. Por ejemplo, si el usuario introduce 3 y 5 
se escribirá “3 4 5”, mientras que si introduce 6 y 4 se escribirá
 “6 5 4”. Lo debes hacer de tres formas distintas:
a)    Usando “for”
b)    Usando “while”
c)     Usando “do..while”
*/

// José Vicente Antón Castelló

// Nota: esta solución tiene un error:
// - Error: falla (el do-while) si los dos números son iguales


using System;

public class Loops2017
{
    public static void Main()
    {
        Console.Write("Introduce a number: ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce a number: ");
        int final = Convert.ToInt32(Console.ReadLine());
        
        int jump = first < final ? 1 : -1;
        
        for (int i = first; i != final; i += jump)
        {
            if (i != 0)
                Console.Write(i + " ");
        } 
        Console.WriteLine(final);
        
        int j = first;
        while (j != final)
        {
            if (j != 0)
                Console.Write(j + " ");
            j += jump;
        } 
        Console.WriteLine(final);
        
        Console.ReadLine();
        j = first;
        do
        {
            if (j != 0) 
                Console.Write(j + " ");
            j += jump;
        } while (j != final);
        Console.WriteLine(final);
    }
}
