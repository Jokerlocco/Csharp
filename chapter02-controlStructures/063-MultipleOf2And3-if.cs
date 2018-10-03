// Multiple of 2 and 3? (v2: if)

using System;

public class MultipleOf2And3
{
    public static void Main()
    {
        int n;

        Console.Write("Enter a number (1 to 10): ");
        n = Convert.ToInt32(Console.ReadLine());
        
        if ((n < 1) || (n > 10))
            Console.WriteLine("Not a valid number");
        else if ((n % 2 == 0) && (n % 3 == 0))
            Console.WriteLine("Is a multiple of 2 and 3");
        else if (n % 2 == 0)
            Console.WriteLine("Is a multiple of 2");
        else if (n % 3 == 0)
            Console.WriteLine("Is a multiple of 3");
        else
            Console.WriteLine("Is a not multiple of 2 nor 3");
    }
}
