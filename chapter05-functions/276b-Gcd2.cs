// Greatest common divider, recursive + iterative
// Adrián Navarro Gabino

using System;

public class FunctionGcd
{
    public static long GcdR(long a, long b)
    {
        long greatest;
        long lowest;
        
        if(a >= b)
        {
            greatest = a;
            lowest = b;
        }
        else
        {
            greatest = b;
            lowest = a;
        }
        
        if(lowest == 0)
        {
            return greatest;
        }
        
        return GcdR(lowest, greatest % lowest);
        
    }
    
    public static long Gcd(long a, long b)
    {
        long greatest;
        long lowest;
        
        if(a >= b)
        {
            greatest = a;
            lowest = b;
        }
        else
        {
            greatest = b;
            lowest = a;
        }
        
        long Gcd = 1;
        
        for(int i = 1; i <= lowest; i++)
        {
            if(lowest % i == 0 && greatest % i == 0)
                Gcd = i;
        }
        
        return Gcd;
    }
    
    
    public static void Main()
    {
        Console.WriteLine(GcdR(18,12));
        Console.WriteLine(Gcd(18,12));
    }
}
