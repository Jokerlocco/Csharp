// Jorge Calzada Asenjo
// Calcular aproximación de pi usando fórmula de Leibniz
// Jorge Calzada

/*
Cree un programa para calcular una aproximación para PI usando la expresión

pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 ...


El usuario indicará cuántos términos se deben usar y el programa mostrará todos 
los resultados hasta esa cantidad de términos.

Nota: debes usar el tipo de datos "double"
*/

using System;

public class Pi
{
    public static void Main()
    {
        int num, signo = -1;
        double pi = 1, divisor = 3;

        Console.Write("¿Cuántos términos quieres usar? ");

        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < num; i++)
        {
            pi = pi + (1 / divisor * signo);
            divisor = divisor + 2;
            signo = -signo;
        }
        pi = pi * 4;
        Console.WriteLine("Pi es " + pi);
    }
}
