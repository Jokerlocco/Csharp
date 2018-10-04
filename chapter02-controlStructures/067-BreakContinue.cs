// Gonzalo Arques
// Example of break and continue

using System;

public class BreakAndContinue
{
    public static void Main ()
    {
        for ( int i = 1; i <= 5; i++ )
        {
            if ( i == 3 )
                break;
            Console.Write("{0} ", i );
        }
        Console.WriteLine();
        // Result: 1 2
        
        for ( int i = 1; i <= 5; i++ )
        {
            if ( i == 3 )
                continue;
            Console.Write("{0} ", i );
        }
        Console.WriteLine();
        // Result: 1 2 4 5
    }
}
