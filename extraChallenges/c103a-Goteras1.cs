// Manuel Lago
// Challenge 1.03: "Goteras"

/*
Sample input
3
70
3600
3661
Sample output
00:01:10
01:00:00
01:01:01
*/

using System;

public class Gotera
{
    public static void Main()
    {
        int cases, input, i;
        int hours, minutes, seconds;
        
        cases = Convert.ToInt32( Console.ReadLine() );
        
        for ( i = 1 ; i <= cases ; i++ )
        {
            input = Convert.ToInt32( Console.ReadLine() );
            
            hours = input / 3600;
            minutes = (input % 3600) / 60;
            seconds = input % 60;
        
            for ( int j = input ; j == input ; j++)
            {
                if ( hours < 10 )
                    Console.Write("0{0}:",hours);
                else
                    Console.Write("{0}:",hours);
            
                if ( minutes < 10 )
                    Console.Write("0{0}:",minutes);
                else
                    Console.Write("{0}:",minutes);
            
                if ( seconds < 10 )
                    Console.Write("0{0}",seconds);
                else
                    Console.Write("{0}",seconds);
            }
            Console.WriteLine();
        }
    }
}
