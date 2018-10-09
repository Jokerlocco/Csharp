// Quitting two nested loops with "goto"

using System;

public class TwoNestedLoops
{
    public static void Main()
    {
        
        int i, j;
        
        for ( i = 1; i <= 10; i++)
        {
            Console.Write("i={0} ",i);
            for ( j = 20; j <= 30; j = j + 2)
            {    
                Console.Write("j={0} ",j);

                if (( i == 3) && (j > 25))
                    goto fin;
            }
        }
        fin:
            Console.WriteLine("Hemos salido!");
    }
}
