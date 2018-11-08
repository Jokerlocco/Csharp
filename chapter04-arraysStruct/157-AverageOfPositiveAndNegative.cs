// María González Martínez
// Average of positive and negative numbers

using System;
public class Averages
{
    public static void Main()
    {
        const int SIZE = 10;
        float[] values = new float [SIZE];
        int positiveCount = 0, negativeCount = 0;
        float positiveSum = 0, negativeSum = 0;
        float positiveAvg, negativeAvg;
        
        for (int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter data {0}: ", i+1);
            values[i] = Convert.ToSingle(Console.ReadLine());
            
            if(values[i] > 0)
            {
                positiveCount++;
                positiveSum += values[i];
            }
            if(values[i] < 0)
            {
                negativeCount++;
                negativeSum += values[i];
            }
        }
        
        if(positiveCount > 0)
        {
            positiveAvg = positiveSum / positiveCount;
            Console.WriteLine("Average of the positive values: " + 
                positiveAvg);
        }
        else
            Console.WriteLine("There are no positive values");
            
        if(negativeCount > 0)
        {
            negativeAvg = negativeSum / negativeCount;
            Console.WriteLine("Average of the negative values: " + 
                negativeAvg);
        }
        else
            Console.WriteLine("There are no negative values");
    }
}
