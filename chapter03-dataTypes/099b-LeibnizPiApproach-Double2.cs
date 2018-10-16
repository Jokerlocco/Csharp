// Aproximation of Pi, Leibniz formula using double data type
// José Vicente Antón Castelló

using System;

public class PiLeibnizFormulaDouble
{
    public static void Main()
    {
        Console.Write("How many steps? ");
        double lastDenominator = Convert.ToDouble(Console.ReadLine()) * 2 + 1;
        
        double pi = 0;
        
        for (double d = 1; d < lastDenominator; d = d + 2)
            pi = -pi + (1 / d);
        
        if (pi < 0)
            pi = -pi;
            
        pi = pi * 4;
        
        Console.WriteLine("Pi is {0}", pi);
    }
}
