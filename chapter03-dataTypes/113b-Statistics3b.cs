// Diego Aníbal Lezcano Reissner
// Statistics3: Sum, average, max, min (b: do-while)

using System;

public class Statistics3b
{
    public static void Main ()
    {
        
        double n, average = 0, sum = 0;
        double min = 0, max = 0;
        double numberToFinish = 0;
        int count = 0;
        bool finished = false;
        
        do
        {
            Console.Write("Dato: ");
            n = Convert.ToDouble(Console.ReadLine());
            
            if(n == numberToFinish)
            {
                finished = true;
            }
            
            if(count == 0)
            {
                min = n;
                max = n;
            }
            
            if(!finished)
            {
                if(n > max)
                {
                    max = n;
                }
                
                if(n < max)
                {
                    min = n;
                }
                
                count++;
                sum = sum + n;
                average = sum / count;
                
                Console.Write("Max = {0}, ", max);
                Console.Write("Min = {0}, ", min);
                Console.Write("Sum: {0}, ", sum);
                Console.WriteLine("Averafe: {0} " , average);
            }
        }
        while(!finished);
        
        Console.WriteLine("Bye!");
    }
}
