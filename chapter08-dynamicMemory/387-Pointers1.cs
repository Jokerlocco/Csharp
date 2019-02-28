using System;

public class Pointers1
{
    unsafe static void Main()
    {
        int x;
        int y;
        x = 2;
        y = 50;

        Console.WriteLine(x);
        Console.WriteLine(y);

        int* posicion;
        posicion = &x;
        Console.WriteLine((long)posicion);

        posicion = &y;
        Console.WriteLine((long)posicion);

        *posicion = 501;
        Console.WriteLine(y);
    }
}
