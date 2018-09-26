// Challenge 1.01: The watermelon
// Can the watermelon be split in two pieces, weighting an even
//  number of kilos each? (Codeforces 4A)

// Manuel Lago

using System;

public class Challenge101
{
    public static void Main()
    {
        int weight = Convert.ToInt32( Console.ReadLine() );
        if (( weight > 2 ) && ( weight % 2 == 0 ))
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}
