// Jorge Calzada Asenjo
// Sum numbers from a spaces-delimited string (2: foreach)

using System;

public class SumString2
{
    public static void Main()
    {
        int total = 0;

        Console.Write("Enter some space separated numbers: ");
        string[] values = Console.ReadLine().Split();

        foreach(string v in values)
            total += Convert.ToInt32( v );
        Console.WriteLine(total);
    }
}
