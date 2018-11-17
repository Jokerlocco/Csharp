// Bubble sort
// Jorge Calzada

using System;

public class BubbleSort
{
    public static void Main()
    {
        const int SIZE = 5;
        int aux;

        // Let's ask for data
        
        int[] data = new int[SIZE];
        for (int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            data[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        // And display the array
        for (int z = 0; z < SIZE; z++)
        {
            Console.Write(data[z] + " ");
        }
        Console.WriteLine();
        

        // Now let's sort
        for (int i = 0; i < SIZE - 1; i++)  // Each invidual data
        {
            for (int j = i + 1; j < SIZE; j++) // With the following ones
            {
                if (data[i] > data[j])   // If the smaller is not first
                {
                    aux = data[i];       // The, we swap them
                    data[i] = data[j];
                    data[j] = aux;
                }
            }
            
            // Let's display the progress ater each pass (optional)
            for (int z = 0; z < SIZE; z++)
            {
                Console.Write(data[z] + " ");
            }
            Console.WriteLine();
        }
    }
}
