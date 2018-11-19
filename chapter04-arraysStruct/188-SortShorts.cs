// Sorting unsigned shorts

using System;

public class SortShort
{
    public static void Main()
    {
        const int SIZE = 5;
        ushort aux;

        ushort[] data = new ushort[SIZE];
        for (int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            data[i] = Convert.ToUInt16(Console.ReadLine());
        }
        

        for (int i = 0; i < SIZE - 1; i++)
        {
            for (int j = i + 1; j < SIZE; j++)
            {
                if (data[i] > data[j])
                {
                    aux = data[i];
                    data[i] = data[j];
                    data[j] = aux;
                }
            }
        }
        
        foreach (ushort n in data)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
    }
}
