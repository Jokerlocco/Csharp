//Jaime Francisco Rebollo Domínguez

using System;

class Hardware
{
    public static void ClearScreen()
    {
        for(int i = 0; i < 25; i++)
            Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        ClearScreen();
    }
}
