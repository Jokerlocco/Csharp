// Jaime Francisco Rebollo Domínguez
// Min, max, median

using System;

public class MinMaxMedian
{
    public static void Main()
    {
        const short SIZE = 7;
        short[] data = new short[SIZE];
        short aux;

        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter data {0}: ", i+1);
            data[i] = Convert.ToInt16(Console.ReadLine());
        }

        for (int i = 0; i < SIZE - 1; i++)
        {
            for(int j = i+1 ; j < SIZE; j++)
            {
                if(data[i] > data[j])
                {
                    aux = data[i];
                    data[i] = data[j];
                    data[j] = aux;
                }
            }
        }
        
        Console.WriteLine("Median: {0}", data[(SIZE-1)/2]);
        Console.WriteLine("Mín: {0}", data[0]);
        Console.WriteLine("Máx: {0}", data[SIZE-1]);
    }
}
