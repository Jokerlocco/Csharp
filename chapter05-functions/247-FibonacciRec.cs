using System;

public class RecursiveFibonacci
{
    public static int Fibonacci(int n)
    {
        // Base case
        if (n == 0)
            return 0;
        
        if (n == 1)
            return 1;

        // General case
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    public static void Main()
    {
        for (int i = 0; i < 11; i++)
        {
            Console.Write("{0} ",Fibonacci(i));
        }
    }
}
