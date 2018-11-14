// Jorge Calzada

using System;

public class IdentityMatrix
{
    public static void Main()
    {
        const int ROWS = 3;
        const int COLUMNS = 3;
        int[,] matrix = new int[ROWS,COLUMNS];

        for (int row = 0; row < ROWS; row++)
        {
            for (int column = 0; column < COLUMNS; column++)
            {
                Console.Write("Enter data for row {0}, column {1}: ", 
                    row + 1, column + 1);
                matrix[row, column] = Convert.ToInt32(Console.ReadLine());
            }
        }

        bool isIdentityMatrix = true;

        for (int row = 0; row < ROWS; row++)
        {
            for (int column = 0; column < COLUMNS; column++)
            {
                if ((row == column && matrix[row,column] != 1) ||
                    (row != column && matrix[row, column] != 0))
                {
                    isIdentityMatrix = false;
                }
            }
        }

        if (isIdentityMatrix)
        {
            Console.WriteLine("It is an identity matrix");
        }
        else
        {
            Console.WriteLine("It is NOT an identity matrix");
        }
    }
}
