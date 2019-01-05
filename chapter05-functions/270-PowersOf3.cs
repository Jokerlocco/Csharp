/*
270 - Repaso Navidad 15 - Función EscribirPotenciasDe3

Crea dos funciones que muestren las primeras n+1 potencias de 3, acabando con n 
= 0. La primera función debe hacerlo de forma iterativa (NO recursiva, pero 
usando "para" o "while"), y debe llamarse "EscribirPotenciasDe3". Para calcular 
cada una de las potencias, puedes usar "Math.Pow" o crear una función 
"Potencia" hecha por ti. La segunda función debe hacerlo de forma recursiva, y 
debe llamarse "EscribirPotenciasDe3r".

Un ejemplo de uso podría ser:

EscribirPotenciasDe3( 4 );

81 27 9 3 1

EscribirPotenciasDe3r( 4 );

81 27 9 3 1
*/

// Daniel Contreras

using System;

class RepasoNavidad270
{
    static void EscribirPotenciasDe3(int num)
    {
        while (num >= 0)
        {
            Console.Write((int)Math.Pow(3, num ) + " ");
            num--;
        }
    }
    
        
    static void EscribirPotenciasDe3r(int num)
    {
        if (num == 0)
        {
            Console.Write(1);
        }
        else
        {
            Console.Write((int)Math.Pow(3, num ) + " ");
            EscribirPotenciasDe3r(num-1);    
        }
        
    }
    
    static void Main()
    {
        EscribirPotenciasDe3(4);
        Console.WriteLine();
        EscribirPotenciasDe3r(4);
    }
}
