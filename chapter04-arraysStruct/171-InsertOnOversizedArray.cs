// José Vicente Antón Castelló

using System;

public class OversizedArray
{
    public static void Main()
    {
        const int SIZE = 100;
        byte option;
        int currentPosition = 0;
        int desiredPosition;
        string[] data = new string[SIZE];
        string newData;
        
        do
        {
            // Show Menu
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Show all");
            Console.WriteLine("3. Insert between two existant data");
            Console.WriteLine("0. Exit");
            option = Convert.ToByte(Console.ReadLine());

            switch (option)
            {
                // Option 1: Add
                case 1:
                {
                    if (currentPosition < SIZE)
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
                    break;
                // Option 2: Show all
                case 2:
                {
                    for (int i = 0; i < currentPosition; i++)
                    {
                        Console.WriteLine(data[i]);
                    }
                }
                    break;
                // Option 3: Insert between two existant data
                case 3:
                {
                    if (currentPosition < SIZE)
                    {
                        Console.WriteLine("Enter data");
                        newData = Console.ReadLine();
                        
                        Console.WriteLine("Enter the desired position");
                        desiredPosition = Convert.ToInt32(Console.ReadLine());
    
                        if (desiredPosition < currentPosition 
                                && desiredPosition > 0)
                        {
                            for (int i=currentPosition; i>desiredPosition; i--)
                            {
                                data[i] = data[i - 1];
                            }
                            data[desiredPosition - 1] = newData;
                            currentPosition++;
                        }
                        else
                        {
                            Console.WriteLine("Invalid position");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Database full");
                    }
                }
                    break;
            }
        }
        while (option != 0);
    }
}
