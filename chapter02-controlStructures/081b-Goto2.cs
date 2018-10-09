// Creating a loop with "goto" (2)

using System;

public class Goto
{
    public static void Main()
    {
        int n = 1;
        
    writeOnceMore:
        
        Console.Write("{0} ", n);
        if (n >= 10)
            goto endOfProgram;
            
        n++;
        goto writeOnceMore;
        
    endOfProgram:
        ; 
        
    }
}
