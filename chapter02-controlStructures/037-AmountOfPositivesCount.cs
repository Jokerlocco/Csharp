// Amount of positives (+ count)
// Jaime Rebollo Domínguez

using System;

public class AmountOfPositivesCount
{
    public static void Main()
    {
        int num1, num2, count;
        
        count = 0;
        
        Console.Write("Enter a number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter another number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if ( num1 > 0 )
            count = count + 1;
        
        if ( num2 > 0 )
            count = count + 1;
        
        Console.WriteLine("{0} of them are positive", count);
    }
}
