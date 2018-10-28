//Kevin Marín Romero

using System;

public class Fibonacci
{
    public static void Main()
    {
        double n, f0, f1, sum, previous, division;
        
        Console.Write("How many terms? ");
        n = Convert.ToInt32(Console.ReadLine());
        
        f0 = 0;
        f1 = 1;
        sum = 0;
        previous = 0;
        
        if (n == 0)
            Console.Write(f0 + " ");
        else if (n == 1)
        {
            Console.Write(f1 + " ");
            sum = 1;
        }
        else
        {
            sum = 1;
            for(int i = 1; i < n; i++)
            {
                previous = sum;
                sum = f0 + f1;
                f0 = f1;
                f1 = sum;
            }
            
            Console.WriteLine("Fib({0}) = {1}", n, sum);
        }
        division = sum / previous;
        Console.WriteLine("Golden ratio (so far) = {0}", division);
    }
}
