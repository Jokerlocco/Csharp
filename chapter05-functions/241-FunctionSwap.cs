// Function Swap (ref parameters)

using System;

public class FunctionSwap
{
    public static void Swap(ref int x, ref int y)
    {
        int aux = x;
        x = y;
        y = aux;
    }
        
    public static void Main()
    {
        int x=2, y=3;
        Swap(ref x, ref y);
        // This should display "x=3, y=2"
        Console.WriteLine("x={0}, y={1}", x, y);
    }
}
