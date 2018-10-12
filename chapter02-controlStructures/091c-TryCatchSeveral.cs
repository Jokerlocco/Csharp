using System;

public class TryCathEx3
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
                
            Console.WriteLine("Division: {0}", a/b);
            Console.WriteLine("Product: {0}", a*b);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Error, can't divide by 0");
        }
        catch(FormatException)
        {
            Console.WriteLine("Are you kidding me?");
        }
    }
}
