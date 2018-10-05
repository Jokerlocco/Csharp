// Prime factors (v5: while n > 1)

using System;

public class Factors
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("{0} = ", n);
        
        int divider = 2;
        while(n > 1)
        {
            if(n % divider == 0)
            {
                Console.Write("{0} ", divider);
                n = n / divider;
            }
            else
                divider++;
        }
        
        Console.WriteLine();
    }
}
