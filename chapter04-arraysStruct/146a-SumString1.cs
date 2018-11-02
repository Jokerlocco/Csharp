// Jorge Calzada Asenjo
// Sum numbers from a spaces-delimited string (1: for)

using System;

public class SumString1
{
    public static void Main()
    {
        int total = 0;

        Console.Write("Enter some space separated numbers: ");
        string[] values = Console.ReadLine().Split();

        for (int i = 0; i < values.Length; i++)
            total += Convert.ToInt32(values[i]);
        Console.WriteLine(total);
    }
}
