// Creating a loop with "goto" (1)

using System;

public class Goto
{
    public static void Main()
    {
        int n = 1;
        
    writeOnceMore:
        
        Console.Write("{0} ", n);
        if (n < 10)
        {
            n++;
            goto writeOnceMore;
        }
        
    }
}
