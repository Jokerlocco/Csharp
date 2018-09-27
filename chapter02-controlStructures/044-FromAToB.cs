using System;

public class FromAToB
{
    public static void Main()
    {
        Console.Write("Enter the lower limit: ");
        int lowerLimit = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the upper limit: ");
        int upperLimit = Convert.ToInt32(Console.ReadLine());
        
        int current = lowerLimit;
        
        while (current <= upperLimit )
        {
            Console.WriteLine(current);
            current = current + 1;
        }
    }
}
