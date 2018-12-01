// Function Double, passing parameters by reference

using System;

public class DoubleByRef
{
    public static void Double(ref int n)
    {
        n *= 2;
    }
    
    public static void Main()
    {
        int number = 3;
        Console.WriteLine(number);
        Double(ref number);
        Console.WriteLine(number);
    }
}
