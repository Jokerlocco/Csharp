// Display many asterisks (for, v1)

using System;

public class AsterisksFor1
{
    public static void Main()
    {
        Console.Write("How many asterisks? ");
        int amount = Convert.ToInt32(Console.ReadLine());
        
        for (int count = 1  ; count <= amount ; count = count + 1)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
