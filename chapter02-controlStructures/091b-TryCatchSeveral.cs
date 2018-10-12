using System;

public class TryCathEx2
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
        catch(Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
    }
}
