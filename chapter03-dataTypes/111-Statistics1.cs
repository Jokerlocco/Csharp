// Kevin Marín Romero
// Statistics1: Sum

using System;

public class Statistics1
{
    public static void Main()
    {
        double num, sum = 0;
        
        do
        {
            Console.Write("Data? ");
            num = Convert.ToDouble(Console.ReadLine());
            
            if(num != 0)
            {
                sum = sum + num;
                Console.WriteLine("Sum = {0}", sum);
            }
        }
        while(num != 0);
        Console.WriteLine("Bye!");
    }
}
