// José Vicente Antón Castelló

using System;

class RecursivePower
{
    static ulong Power(ulong b, ulong e)
    {
        if (e == 0)
        {
            return 1;
        }
        
        return b * Power(b , e - 1);
    }
    
    static void Main()
    {
        Console.WriteLine(Power(2, 3));
    }
}
