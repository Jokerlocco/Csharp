/* Manuel Rojas Henarejos
19/09/2018 */

/*
Usage example:

Introduce el peso en libras: 5
5 libras son 80 onzas
5 libras son 2265 gramos

(Version 2: more precision: "5 libras son 2267 gramos")

*/


using System;
public class ExamenB
{
    public static void Main()
   {
        int libras, onzas, gramos;
        Console.Write("Introduce el peso en libras: ");
        libras=Convert.ToInt32(Console.ReadLine());

        onzas= libras * 16;
        gramos= libras * 453;
        Console.WriteLine("{0} libras son {1} onzas", libras, onzas);
        Console.WriteLine("{0} libras son {1} gramos", libras, gramos);
        
        gramos= libras * 453592/1000;
        Console.WriteLine("{0} libras son {1} gramos", libras, gramos);
    }
}

