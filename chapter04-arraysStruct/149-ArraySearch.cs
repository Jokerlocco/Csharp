// Search in an array

using System;

public class SearchInArray
{
    public static void Main()
    {
        const int SIZE = 5;
        byte[] data = new byte[SIZE];
        byte search, amount;

        for (int i = 0; i < SIZE; i++)
        {
            Console.WriteLine("Enter data {0}: ", i+1);
            data[i] = Convert.ToByte(Console.ReadLine());
        }

        Console.WriteLine("Enter data to search: ");
        search = Convert.ToByte(Console.ReadLine());

        amount = 0;
        foreach (byte b in data)
        {
            if (b == search)
            {
                amount++;
            }
        }

        if (amount == 0)
        {
            Console.WriteLine("Not found");
        }
        else
        {
            Console.Write("Found {0} times, in positions: ", amount);
            for (int i = 0; i < SIZE; i++)
            {
                if (data[i] == search)
                    Console.Write((i+1) + " ");
            }
            Console.WriteLine();
        }
    }
}
