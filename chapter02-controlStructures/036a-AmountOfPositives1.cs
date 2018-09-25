// Sergio Ruescas

using System;

public class AmountOfPositives1
 {
    public static void Main ()
    {
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
            
        if ((num1 > 0) && (num2 > 0))
            Console.WriteLine("Both numbers are positive");
        else if ((num1 > 0) || (num2 > 0))
            Console.WriteLine("One of them is positive");
        else
            Console.WriteLine("None of them is positive");
    }
}
