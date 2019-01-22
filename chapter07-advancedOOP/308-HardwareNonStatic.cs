// Javier Benajes

using System;

public class Hardware
{
    public void BorrarPantalla()
    {
        for (int i = 0; i < 25; i++)
            Console.WriteLine();
    }
}

class PruebaBorrarPantalla
{
    public static void Main()
    {
        Hardware hw = new Hardware();

        hw.BorrarPantalla();
    }
}
