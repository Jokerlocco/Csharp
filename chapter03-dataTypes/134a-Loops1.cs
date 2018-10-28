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

// Autor desconocido

// Nota: esta solución tiene un detalle mejorable y un par de errores:
// - Mejorable: demasiado código repetitivo
// - Error: muestra el valor 0 y no debería
// - Error: falla si los dos números son iguales

using System;

class Bucles
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        int i;
        if (num2 > num1)
        {
            for (i = num1; i <= num2; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            
            i = num1;
            while (i <= num2)
            {
                Console.Write("{0} ", i);
                i++;
            }
            Console.WriteLine();
            
            i = num1;
            do
            {
                Console.Write("{0} ", i);
                i++;
            } while (i <= num2);
            Console.WriteLine();
        }
        
        if (num1 > num2)
        {
            for (i = num1; i >= num2; i--)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            
            i = num1;
            while (i >= num2)
            {
                Console.Write("{0} ", i );
                i--;
            }
            Console.WriteLine();
            
            i = num1;
            do
            {
                Console.Write("{0} ", i);
                i--;
            } while (i >= num2);
            Console.WriteLine();
        }
    }
}
