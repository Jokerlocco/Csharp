// Function Double, passing parameters by value
// Adrián Navarro Gabino

using System;

public class DoubleByValue
{
    public static void Double(int n)
    {
        n *= 2;
    }
    
    public static void Main()
    {
        int number = 3;
        Console.WriteLine(number);
        Double(number);
        Console.WriteLine(number);
    }
}
