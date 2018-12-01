using System;

public class FunctionAverage
{
    public static double Average(
      double n1, double n2, double n3)
    {
        double average = (n1+ n2 + n3) / 3;
        return average;
    }
    
    public static void Main()
    {
        Console.WriteLine( Average(7, 5, 6.4) );
    }
}
