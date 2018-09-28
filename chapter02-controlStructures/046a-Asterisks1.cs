// Display many asterisks (v1)

using System;

public class Asterisks1
{
    public static void Main()
    {
        Console.Write("How many asterisks? ");
        int amount = Convert.ToInt32(Console.ReadLine());
        
        int count = 1;
        while ( count <= amount )
        {
            Console.Write("*");
            count = count + 1;
        }
        Console.WriteLine();
    }
}
