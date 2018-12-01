using System;

public class FunctionAverage
{
    public static void ShowAverage(
      double n1, double n2, double n3)
    {
        double average = (n1+ n2 + n3) / 3;
        Console.Write(average);
    }
    
    public static void Main()
    {
        ShowAverage(7, 5, 6.4);
    }
}
