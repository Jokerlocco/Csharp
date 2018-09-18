// Manuel Lago
// Conversion mmHg -> bars
// 1 bar = 750,062 mmHg

using System;

public class mmHgconvert
{
    public static void Main()
    {
        int mmHg;
        
        Console.Write( "How many mmHg? " );
        mmHg = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine("{0} mmHg are {1} bar", mmHg, mmHg / 750.062);
    }
}
