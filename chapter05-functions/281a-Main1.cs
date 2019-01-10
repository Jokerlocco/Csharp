// "Main" for the previous functions
// Jorge Calzada Asenjo

using System;

public class MenuHerramientas2
{
    public static int Main(string[] args)
    {
        int exitCode = 0;

        if (args.Length > 0)
        {
            switch (args[0].ToLower())
            {
                case "max":
                    if (args.Length == 2)
                        Console.WriteLine(ObtenerMayorDigito(Convert.ToInt64(
                            args[1])));
                    else
                        exitCode = 2;
                    break;
                case "digitos":
                    if (args.Length == 2)
                        Console.WriteLine(ObtenerDigitos(Convert.ToDouble(
                            args[1])));
                    else
                        exitCode = 2;
                    break;
                case "cuadro":
                    if (args.Length == 2)
                        MostrarRecuadroRedondeado(Convert.ToInt32(args[1]), 5);
                    else
                        exitCode = 2;
                    break;
                case "contiene":
                    if (args.Length == 3)
                    {
                        if (Contains(args[1], Convert.ToChar(args[2])))
                            Console.WriteLine("La letra es parte de la cadena");
                        else
                            Console.WriteLine("La letra no es parte de la " +
                                "cadena");
                    }
                    else
                        exitCode = 2;
                    break;
                default:
                    exitCode = 1;
                    break;
            }
        }
        else
            exitCode = 1;

        if (exitCode == 1)
            Console.WriteLine("Uso: max / digitos / cuadro / contiene");
        else if (exitCode == 2)
            Console.WriteLine("Faltan parámetros");

        return exitCode;
    }

    // -------------------------------------------------

    public static int ObtenerMayorDigito(long n)
    {
        int mayor = (int)n % 10;

        n = n / 10;

        while (n > 10)
        {
            if (n % 10 > mayor)
                mayor = (int)n % 10;

            n = n / 10;
        }

        return mayor;
    }


    public static int ObtenerDigitos(double n)
    {
        string numberString = n.ToString();

        int cifrasEnteras =
            numberString.IndexOf(',');

        if (cifrasEnteras == -1)
            cifrasEnteras = numberString.Length;

        return cifrasEnteras;
    }


    public static void MostrarRecuadroRedondeado(int w, int h)
    {
        Console.WriteLine("/" + new string('-', w - 2) + "\\");

        string interior = "|" + new string(' ', w - 2) + "|";

        for (int i = 0; i < h - 2; i++)
            Console.WriteLine(interior);

        Console.WriteLine("\\" + new string('-', w - 2) + "/");
    }


    public static bool Contains(string text, char c)
    {
        bool found = false;

        for (int i = 0; i < text.Length; i++)
            if (text[i] == c)
                found = true;

        return found;
    }
}
