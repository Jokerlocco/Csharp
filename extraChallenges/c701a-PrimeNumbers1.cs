/*
Olimpiada Informatica UA 2017

Problema 1: Calculador de números primos (3 puntos)

Un número primo es un número entero que sólo es divisible por sí mismo 
y por 1. Es decir, si no hay ningún número entre 1 (sin incluir a éste) 
y n que pueda dividir a n sin resto, entonces n es primo.

Se pide realizar un programa que calcule los números primos que se 
encuentran en el rango desde 2 hasta m. El programa debe pedir un 
número máximo m e imprimir todos los primos en el rango indicado.

Ejemplo de funcionamiento

Introduzca el valor m: 21 
Números primos: 2 3 5 7 11 13 17 19
*/

// Adrián Navarro Gabino

using System;

public class PrimeNumbers
{
    public static bool IsPrime(int number)
    {
        for(int i = 2; i < Math.Sqrt(number); i++)
        {
            if(number % i == 0)
                return false;
        }
        
        return true;
    }
    
    
    public static void Main()
    {
        Console.Write("Introduzca el valor m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        
        if(m >= 2)
            Console.Write("Números primos: 2");
        
        for(int i = 3; i <= m; i++)
            if(IsPrime(i))
                Console.Write(" " + i);
        
        Console.WriteLine();
    }
}
