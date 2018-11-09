/*

Create a program to ask the user for 20 real numbers, store them in two 
arrays of 10 numbers each (named "data1" and "data2"), and then display 
the average of the values which are stored in the first array and then 
the average of the values in the second array.

*/

using System;

public class AverageTwoArrays
{
    public static void Main()
    {
        const int SIZE = 10;
        double[] data1 = new double[SIZE];
        double[] data2 = new double[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            Console.WriteLine("Enter data for pos {0} in block 1: ", i+1);
            data1[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < SIZE; i++)
        {
            Console.WriteLine("Enter data for pos {0} in block 2: ", i + 1);
            data2[i] = Convert.ToDouble(Console.ReadLine());
        }

        double sum1 = 0;
        foreach (double d1 in data1)
            sum1 += d1;
        double average1 = sum1 / SIZE;

        double sum2 = 0;
        foreach (double d2 in data2)
            sum2 += d2;
        double average2 = sum2 / SIZE;

        double average = (average1 + average2) / 2;
        Console.WriteLine("The global average is: "+average);
    }
}
