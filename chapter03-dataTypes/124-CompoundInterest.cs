// Jorge Calzada Asenjo

using System;

public class InteresCompuesto
{
    public static void Main()
    {
        decimal capital, tiempo, interesInicial;
        decimal multiplicador, final;

        //Dinero que mete, tiempo e interes
        //0.1

        Console.Write("Introduce el dinero que ingresas: ");
        capital = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Introduce la cantidad de años: ");
        tiempo = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Introduce el interes (de 1 a 100): ");
        interesInicial = Convert.ToDecimal(Console.ReadLine());

        final = 1;
        multiplicador = 1 + interesInicial / 100;

        for (int i = 0; i < tiempo; i++)
        {
            final *= multiplicador;
        }

        final *= capital;

        Console.Write("Si ingresas {0} euros durante {1} años al {2}%, "+
            "al final tendrás {3} euros", 
            capital, tiempo, interesInicial, final.ToString("N2"));
    }
}
