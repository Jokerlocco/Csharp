// Is a number even?
// v3: ternary operator in WriteLine

using System;

public class IsEven
{
    public static void Main()
    {
        int n;

        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("even = {0}", 
            n % 2 == 0 ? 1 : 0 );
    }
}
