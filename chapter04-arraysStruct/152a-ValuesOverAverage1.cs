// Create an array containing 10 real numbers entered by the user. 
// Then, show the values which are over the average.

using System;

public class ValuesOverAverage
{
    public static void Main()
    {
        float[] data = new float[10];
        float sum = 0;
        float average;
        
        for(int i = 0; i < 10; i++)
        {
            Console.Write("Enter data {0}: ", i+1);
            data[i] = Convert.ToSingle( Console.ReadLine() );
            sum += data[i];
        }
        
        for(int i = 0; i < 10; i++)
            sum += data[i];
        
        average = sum / 10;
        
        Console.Write("Data over the average: ");
        for(int i = 0; i < 10; i++)
            if( data[i] > average )
                Console.Write("{0} ", data[i]);
        Console.WriteLine();
    }
}
