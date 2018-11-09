// José Vicente Antón Castelló

using System;

class ThreeInARow
{
    static void Main()
    {
        const byte ROWS = 3, COLUMNS = 3;
        
        // First, let's prepare the board
        char[,] data = new char[ROWS, COLUMNS];
        for (byte row = 0; row < ROWS; row++)
        {
            for (byte column = 0; column < COLUMNS; column++)
            {
                data[row, column] = '·';
            }
        }

        // Now, let's ask the user for the current (first) position
        Console.Write("Row? ");
        byte userRow = Convert.ToByte(Console.ReadLine());
        Console.Write("Column? ");
        byte userColumn = Convert.ToByte(Console.ReadLine());

        data [userRow - 1, userColumn - 1] = 'O';

        // And finally let's display the resulting board
        for (byte row = 0; row < ROWS; row++)
        {
            for (byte column = 0; column < COLUMNS; column++)
            {
                Console.Write(data[row, column]);
            }
            Console.WriteLine();
        }
    }
}
