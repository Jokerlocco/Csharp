// Greatest common divider, recursive + iterative
// Sergio Ruescas

using System;

class FunctionGcd
{
    static int Gcd(int a, int b)
    {
        int swap;
        
        if (b > a)
        {
            swap = a;
            a = b;
            b = swap;
        }
        
        while( b != 0 )
        {
            swap = b;
            b = a % b;
            a = swap;
        }
        
        return a;
    }
    
    static int GcdR(int a, int b)
    {
        int swap;
        if (b > a)
        {
            swap = a;
            a = b;
            b = swap;
        }
        
        if (b == 0)
            return a;
        else
            return GcdR(b, a%b);       
    }
    
    
    static void Main()
    {
        Console.Write("Enter number (a): ");
        int a = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("Enter number (b): ");
        int b = Convert.ToInt32( Console.ReadLine() );
        
        Console.WriteLine( Gcd(a, b) );
        Console.WriteLine( GcdR(a, b) );
    }
}
