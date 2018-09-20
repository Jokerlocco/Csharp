/* José Vicente Antón Castelló
   19/09/2018 */

/*
Usage example:

Introduce el peso en libras: 5
5 libras son 80 onzas
5 libras son 2265 gramos

(Version 3: up to miligrams: "5 libras son 2267,960 gramos")
*/


using System;

public class Examen
{
    public static void Main()
    {
        int libras; // Datos de entrada
        int onzas, gramos, gramosDecimal; // Resultados
        
        Console.Write("Introduce el peso en libras: ");
        libras = Convert.ToInt32(Console.ReadLine() );
        
        onzas = libras * 16;
        gramos = libras * 453;
        gramosDecimal = ( libras * 453592) % 1000;
        
        Console.WriteLine("{0} libras son {1} onzas", libras, onzas);
        Console.WriteLine("{0} libras son {1} gramos", libras, gramos);
        
        gramos = libras * 453592 / 1000;
        gramosDecimal = ( libras * 453592) % 1000;
        Console.WriteLine("{0} libras son {1}.{2} gramos", libras, gramos, gramosDecimal);
    }
}
