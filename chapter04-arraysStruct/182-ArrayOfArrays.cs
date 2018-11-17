using System;

public class ArrayOfArrays
{
    public static void Main()
    {
        int[][] myArray = new int[3][];

        myArray[0] = new int[6];
        myArray[1] = new int[5];
        myArray[2] = new int[4];

        for (int row = 0; row < myArray.Length; row++)
        {
            for (int column = 0; column < myArray[row].Length; column++)
            {
                Console.WriteLine("Enter data for row {0} "
                    + "and col {1}", row+1, column+1);
                myArray[row][column] = Convert.ToInt32(
                    Console.ReadLine());
            }
        }


        for (int row = 0; row < myArray.Length; row++)
        {
            for (int column = 0; column < myArray[row].Length; column++)
            {
                Console.Write("[{0},{1}]=", row+1, column+1);
                Console.WriteLine(myArray[row][column]);
            }
        }
    }
}
