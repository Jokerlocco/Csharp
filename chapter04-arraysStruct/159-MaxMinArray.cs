// Max and min of an array

using System;

public class MaxMinArray
{
    public static void Main()
    {
        const int SIZE = 10;
        ulong [] data = new ulong[SIZE];
        ulong max, min;

        for (int i = 0; i < SIZE ; i++)
        {
            Console.Write("Enter value for pos." + (i+1) + ": ");
            data[i] = Convert.ToUInt64(Console.ReadLine());
        }
        
        max = min = data[0];
        foreach (ulong d in data)
        {
            if (d > max)
                max = d;
            if (d < min)
                min = d;
        }
        Console.WriteLine("Max = {0}, min = {1}", max, min);        
    }
}
