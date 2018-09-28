// Display many asterisks (for, v2)

using System;

public class AsterisksFor2
{
    public static void Main()
    {
        Console.Write("How many asterisks? ");
        int amount = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1  ; i <= amount ; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
