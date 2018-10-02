// Is a number even?
// v1: if

using System;

public class IsEven
{
    public static void Main()
    {
        int n, even;

        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0)
            even = 1;
        else
            even = 0;
        
        Console.WriteLine("even = {0}", even);
    }
}
