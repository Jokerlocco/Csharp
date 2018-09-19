// Conversion euros -> yens
// 1 euro = 131.05 yens

using System;

public class EurosToYens
{
    public static void Main()
    {
        int euros, yens;
        
        Console.Write( "How many euros? " );
        euros = Convert.ToInt32( Console.ReadLine() );
        yens = euros * 13105 / 100;
        Console.WriteLine("{0} euros are {1} yens", 
			euros, yens);
    }
}
