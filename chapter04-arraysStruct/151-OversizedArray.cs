// Oversized Array (v1: Add + Show all)

using System;

public class OversizedArray
{
    public static void Main()
    {
        byte option;
        int currentPosition = 0;
        string[] data = new string[100];

        do
        {
            // Show Menu
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Show all");
            Console.WriteLine("0. Exit");
            option = Convert.ToByte(Console.ReadLine());

            // Option 1: Add
            if (option == 1)
            {
                if (currentPosition < 100)
                {
                    Console.WriteLine("Enter data for record {0}",
                        currentPosition + 1);
                    data[currentPosition] = Console.ReadLine();
                    currentPosition++;
                }
                else
                {
                    Console.WriteLine("Database full");
                }
            }
            // Option 2: Show all
            else if (option == 2)
            {
                for (int i = 0; i < currentPosition; i++)
                {
                    Console.WriteLine(data[i]);
                }
            }

        }
        while (option != 0);
    }
}
