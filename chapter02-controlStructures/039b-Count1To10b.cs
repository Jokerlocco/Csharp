// Count 1 to 10, while
// Version 2: in the same line

using System;

public class Count1To10
{
    public static void Main()
    {
        int count = 0;
        
        while ( count < 10 )
        {
            count = count + 1;
            Console.Write("{0} ", count);
        }
        Console.WriteLine();
    }
}
