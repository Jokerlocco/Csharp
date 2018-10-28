//Ivan Lazcano Sindin
using System;

public class MainClass
{
    public static void Main()
    {
        int resultado = 0;
        bool fin = false;
        string entrada;
        int numero;
        double aproximacion;
        do
        {
            Console.Write("Numero? ");
            entrada = Console.ReadLine();
            if (entrada == "fin")
                fin = true;
            else
            {
                numero = Convert.ToInt32(entrada);


                for (int i = 0; i < numero; i++)
                {
                    if ((i * i) == numero)
                    {
                        Console.WriteLine("Raiz: {0} (exacta)", i);
                        resultado = i;
                        i = numero;
                    }
                    else if ((i * i) > numero)
                    {
                        Console.WriteLine("Raiz: {0} (no exacta)", --i);
                        resultado = i;
                        i = numero;

                    }



                }
                if (!((resultado * resultado) == numero))
                {
                    aproximacion = resultado;
                    for (int i = 0; i < 10; i++)
                    {
                        aproximacion += 0.1;
                        if ((aproximacion * aproximacion) >= numero)
                        {
                            Console.WriteLine("Raiz con un decimal: {0}",
                                              aproximacion - 0.1);
                            i = 11;
                        }

                    }

                }
            }
        } while (!fin);

        Console.WriteLine("Sesion terminada");

    }
}
