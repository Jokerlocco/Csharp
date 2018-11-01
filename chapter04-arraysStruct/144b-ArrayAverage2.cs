// Average of an array (2: for+foreach)
// Manuel Lago

using System;

public class AverageOfAnArray
{
    public static void Main()
    {
        double[] data = new double[6];
        double total = 0;

        for ( int i = 0 ; i < 6 ; i++ )
        {
                Console.WriteLine("Enter a number: ");
                data[i] = Convert.ToDouble( Console.ReadLine() );
        }
        
        foreach ( double n in data )
            total += n;
        double average = total / 6;
        
        Console.WriteLine("The average is {0}", average);
    }
}
