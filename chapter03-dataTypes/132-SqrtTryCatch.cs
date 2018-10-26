// Sqrt + try catch
// Cristina Francés

using System;
public class Raiz
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            double root = Math.Sqrt(num);
            Console.WriteLine("Square root : " + root);
        }
        catch (Exception)
        {
            Console.WriteLine("Something did not work!");
        }
    }
}
