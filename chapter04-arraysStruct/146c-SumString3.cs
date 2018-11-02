// Jorge Calzada Asenjo
// Sum numbers from a spaces-delimited string (3: int[])

using System;

public class SumString3
{
    public static void Main()
    {
        int total = 0;


        Console.Write("Enter some space separated numbers: ");
        string[] data = Console.ReadLine().Split();
        
        int[] values = new int[ data.Length ];
        for (int i = 0; i < data.Length; i++)
        {
            values[i] = Convert.ToInt32( data[i] );
        }
        
        foreach(int v in values)
        {
            total += v;
        }
        Console.WriteLine(total);
    }
}
