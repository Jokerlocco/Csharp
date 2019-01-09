// Integer digits and most significant digit
// Adrián Navarro Gabino

using System;

public class FunctionGetDigits
{
    public static void GetDigits(
        double n, ref int intDigits, ref int msd)
    {
        msd = 0;
        
        int num = (int)n;
        int count = 0;
        
        while(num != 0)
        {
            if(num < 10 && num > 0)
                msd = num;
            num /= 10;
            count++;
        }
        
        intDigits = count;
    }
    
    public static void Main()
    {
        int intDigits = 0;
        int msd = 0;
        
        GetDigits(236.78, ref intDigits, ref msd);
        Console.WriteLine(intDigits);
        Console.WriteLine(msd);
        
        GetDigits(0.78, ref intDigits, ref msd);
        Console.WriteLine(intDigits);
        Console.WriteLine(msd);
        
        GetDigits(5, ref intDigits, ref msd);
        Console.WriteLine(intDigits);
        Console.WriteLine(msd);
    }
}
