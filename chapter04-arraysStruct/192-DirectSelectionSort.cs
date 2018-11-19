// Direct Selection sort

using System;

public class DirectSelectionSort
{
    public static void Main()
    {
        const int SIZE = 5;
        int aux;

        int[] data = { 8, 2, 7, 3, 0 };

        // And display the array
        for (int z = 0; z < SIZE; z++)
        {
            Console.Write(data[z] + " ");
        }
        Console.WriteLine();


        // Now let's sort
        for (int i = 0; i < SIZE - 1; i++)
        {
            int posSmallest = i;
            for (int j = i + 1; j < SIZE; j++)
            {
                if (data[posSmallest] > data[j])
                {
                    posSmallest = j;
                }
            }
            if (posSmallest != i)
            {
                aux = data[i];
                data[i] = data[posSmallest];
                data[posSmallest] = aux;
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
   
