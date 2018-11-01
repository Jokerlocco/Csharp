// Average v3: not using arrays

using System;

public class AverageButNoArray
{
    public static void Main()
    {
        double total = 0;

        for ( int i = 0 ; i < 6 ; i++ )
        {
                Console.WriteLine("Enter a number: ");
                total += Convert.ToDouble( Console.ReadLine() );
        }
        Console.WriteLine("The average is {0}", total / 6);
    }
}
