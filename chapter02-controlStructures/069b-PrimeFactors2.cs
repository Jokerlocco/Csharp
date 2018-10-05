// Prime factors (v2: incrementing and decrementing the counter)

using System;

public class Factors
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("{0} = ", n);
        
        for(int i = 2; i <= n; i++)
        {
            if(n % i == 0)
            {
                Console.Write("{0} ", i);
                n = n / i;
                i--;
            }
        }
        
        Console.WriteLine();
    }
}
