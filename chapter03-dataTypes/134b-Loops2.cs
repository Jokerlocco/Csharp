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

// Jorge Calzada Asenjo

using System;

public class Examen1
{
    public static void Main()
    {
        int num1, num2;
        int incremento, i;

        Console.Write("Introduce un número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce otro número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        incremento = num1 < num2 ? 1 : -1;


        for (i = num1; (i <= num2 && incremento == 1) ||
             (i >= num2 && incremento == -1); i += incremento)
            if (i != 0)
                Console.Write(i + " ");

        Console.WriteLine();

        i = num1;
        while ((i <= num2 && incremento == 1) ||
                (i >= num2 && incremento == -1))
        {
            if (i != 0)
                Console.Write(i + " ");
            i += incremento;
        }

        Console.WriteLine();

        i = num1;
        do
        {
            if (i != 0)
                Console.Write(i + " ");
            i += incremento;
        }
        while ((i <= num2 && incremento == 1) ||
                (i >= num2 && incremento == -1));
    }
}
