// Cristina Francés
// Challenge 1.10 - Gregorio XIII
// (days in february -> leap year or not?)

/*
Sample input
4
1584
1600
1699
1700

Sample output
29
29
28
28
*/

using System;

public class DiasFebrero
{
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        
        for ( int i = 1; i <= cases ; i++)
        {
            int year = Convert.ToInt32(Console.ReadLine());
               
            if ( ((year % 4 == 0) && (year % 100 != 0)) 
                    || (year % 400 == 0))
                Console.WriteLine("29");
            else
                Console.WriteLine("28");
        }
    }
}
 
