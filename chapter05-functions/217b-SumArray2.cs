// Function to return the sum of the elements
// in an array of integers (V2: foreach)

// Jorge Calzada

using System;

class SumaNumeros
{
    public static int SumOfArray(int[] numbers)
    {
        int result = 0;

        foreach (int n in numbers)
        {
            result += n;
        }

        return result;
    }

    public static void Main()
    {
        int[] example = {20, 10, 5, 2};
        Console.WriteLine("The sum of the array is {0}",
            SumOfArray(example));
    }
}
