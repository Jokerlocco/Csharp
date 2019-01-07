// Adrián Navarro Gabino

using System;

public class FunctionIsCircularPrime
{
    public static bool IsPrime(long x)
    {
        for(long i = 2; i < x / 2; i++)
        {
            if(x % i == 0)
                return false;
        }
        return true;
    }
    
    public static bool IsCircularPrime(long x)
    {
        string aux = x.ToString();
        int size = aux.Length;
        
        for(int i = 0; i < size; i++)
        {
            aux = aux[size - 1] + aux.Substring(0, size - 1);
            if(!IsPrime( Convert.ToInt64(aux) ))
                return false;
        }
        return true;
    }
    
    
    public static void Main()
    {
        Console.Write("Enter a number: ");
        long x = Convert.ToInt64( Console.ReadLine() );
        if (IsCircularPrime(x))
            Console.WriteLine( x + " is a circular prime");
        else
            Console.WriteLine( x + " is not a circular prime");
    }
}
