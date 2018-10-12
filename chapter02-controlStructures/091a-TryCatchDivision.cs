//Ivan Lazcano Sindin
using System;
public class TryCathEx
{
    public static void Main()
    {
        Console.Write("Enter a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        try
        {
            Console.WriteLine("Division: {0}", a/b);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Error, can't divide by 0");
        }
        
        Console.WriteLine("Product: {0}", a*b);
    }
}
