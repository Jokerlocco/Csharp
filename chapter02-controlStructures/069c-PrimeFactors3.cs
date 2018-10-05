// Prime factors (v3: incrementing only when needed)

using System;

public class Factors
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("{0} = ", n);
        
        for(int i = 2; i <= n; )
        {
            if(n % i == 0)
            {
                Console.Write("{0} ", i);
                n = n / i;
            }
            else
                i++;
        }
        
        Console.WriteLine();
    }
}
