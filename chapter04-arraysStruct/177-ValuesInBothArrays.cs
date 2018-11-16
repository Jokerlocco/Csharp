/*
Create a program to ask the user for 10 integer numbers, store them in a 
2x5 bidimensional array, and then display the values which are stored in 
in both half arrays
*/

using System;

public class BothBidimensional
{
    public static void Main()
    {
        const int ROWS = 2;
        const int COLUMNS = 5;
        int[,] data = new int[ROWS,COLUMNS];

        for (int row = 0; row < ROWS; row++)
            for (int col = 0; col < COLUMNS; col++)
            {
                Console.WriteLine(
                    "Enter data for row {0} and column {1}: ", 
                    row + 1, col + 1);
                data[row,col] = Convert.ToInt32(Console.ReadLine());
            }


        for (int upperColumn = 0; upperColumn < COLUMNS; upperColumn++)
        {
            int currentValue = data[0, upperColumn];
            for (int lowerColumn = 0; lowerColumn < COLUMNS; lowerColumn++)
            {
                if (data[1, lowerColumn] == currentValue)
                    Console.Write( currentValue + " ");
            }
        }
        
        Console.WriteLine();
    }
}
