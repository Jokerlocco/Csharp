// Ivan Lazcano

using System;

class ThreeInARow
{
    static void Main()
    {
        bool player1turn = true;
        const byte ROWS = 3, COLUMNS = 3;
        byte freeSpaces = 9;
        // First, let's prepare the board
        char[,] data = new char[ROWS, COLUMNS];
        for (byte row = 0; row < ROWS; row++)
        {
            for (byte column = 0; column < COLUMNS; column++)
            {
                data[row, column] = '.';
            }
        }

        // Now, let's ask the user for the current (first) position
        do
        {

            Console.WriteLine("Player {0} turn, do you movment", 
                              player1turn? 1 : 2);

            Console.Write("Row? ");
            byte userRow = Convert.ToByte(Console.ReadLine());
            Console.Write("Column? ");
            byte userColumn = Convert.ToByte(Console.ReadLine());
            if (data[userRow - 1, userColumn - 1] != '.')
            {
                Console.WriteLine("Error, position alredy used");
                freeSpaces++;
            }
            else
            {

                if (player1turn)
                {
                    data[userRow - 1, userColumn - 1] = 'O';
                    player1turn = false;
                }
                else
                {
                    data[userRow - 1, userColumn - 1] = 'X';
                    player1turn = true;
                }

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

        } while ( --freeSpaces != 0);
    }
}
