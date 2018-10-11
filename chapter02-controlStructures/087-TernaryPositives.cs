//Daniel Contreras
using System;

public class TernaryPositives
{
    public static void Main()
    {
        int amountOfPositives;
        
        Console.Write("Enter number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        if ((a > 0) && (b > 0))
            amountOfPositives = 2;
        else if ((a > 0) || (b > 0))
            amountOfPositives = 1;
        else
            amountOfPositives = 0;
        
        amountOfPositives = 
            ((a > 0) && (b > 0)) ? 2 : 
            ((a > 0) || (b > 0)) ? 1 : 0;
    }
}
                                
