// Cristina Francés

using System;

public class DirectInsertion
{
    public static void Main()
    {
        const int SIZE = 10; 
        int[] myArray = new int[SIZE];
        int i, j, swap;
        
        for (i = 0; i < SIZE; i++)
        {
            Console.Write("Enter data {0} of {1}: ", i+1, SIZE);
            myArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        for (i = 1; i < SIZE; i++)
        {
            j = i-1;
            
            while ((j >= 0) && (myArray[j] > myArray[j+1]))
            {
                swap = myArray[j];
                myArray[j] = myArray[j+1];
                myArray[j+1] = swap;
                j--;
            }
        }
        
        foreach (int d in myArray)
            Console.Write("{0} ", d);
        Console.WriteLine();
    }
}
