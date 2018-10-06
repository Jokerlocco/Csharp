//Ivan Lazcano
using System;
public class SgnTest
{
    public static void Main()
    {
        int n, sign;
        
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        if (n > 0)
            sign = 1;
        else if (n < 0)
            sign = -1;
        else
            sign = 0;
            
        sign = n > 0 ? 1 : (n < 0 ? -1 : 0) ;
        
        Console.WriteLine(sign);
    }
}
