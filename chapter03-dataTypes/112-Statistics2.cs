// Daniel Contreras
// Statistics2: Sum, average

using System;

class Statistics2
{
    static void Main()
    {
        double data, sum = 0;
        int count = 0;
        
        do
        {
            Console.Write("Data: ");
            data = Convert.ToDouble(Console.ReadLine());
                     
            if (data != 0)
            {
                count++;
                sum = sum + data;
                Console.Write("Sum:{0},", sum);
                Console.WriteLine(" Average = {0}", sum/count);
            }
        } 
        while (data != 0);
        Console.WriteLine("Bye!");
    }
    
}
