// José Vicente Antón Castelló

using System;

class IterativeFactorial
{
    static int Factorial(int num)
    {
        int total = 1;
        
        for (int i = 1; i <= num; i++)
        {
            total *= i;
        }
        return total;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Factorial(5));
    }
}
