// Cristina Francés

using System;

public class SumTwoIntegers
{
    public static int Sum(int n1, int n2)
    {
        return n1 + n2;
    }
    
    public static void Main()
    {
        Console.Write("Enter the first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine( Sum(a, b) );
    }
}
