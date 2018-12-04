using System;

class Factorial
{
    static int Fact(int n)
    {
        // Base case
        if (n == 0)
            return 1;

        // General case
        return n * Fact(n - 1);
    }

    static void Main()
    {
        Console.WriteLine(Fact(3));
    }
}
