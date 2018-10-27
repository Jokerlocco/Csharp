// Jorge Calzada Asenjo

using System;

public class Examen2
{
    public static void Main()
    {
        double num1, num2, num3;
        byte iguales;

        Console.Write("Introduce un número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce otro número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce otro número: ");
        num3 = Convert.ToDouble(Console.ReadLine());

        if (num1 == num2 && num2 == num3)
            iguales = 3;
        else if (num1 == num2 || num2 == num3 || num1 == num3)
            iguales = 2;
        else
            iguales = 1;

        Console.WriteLine(iguales);

        iguales = (num1 == num2 && num2 == num3) ? 3 :
            (num1 == num2 || num2 == num3 || num1 == num3) ? 2 : 1;

        Console.WriteLine(iguales);
    }
}
