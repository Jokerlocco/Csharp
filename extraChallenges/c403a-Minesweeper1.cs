//Kevin Marín Romero
//Minesweeper

/*
Sample input

5 4
*--**
---*-
---**
***--
4 5
**-*
****
*--*
**-*
-***
0 0

Sampleoutput

0
3
*/

using System;

public class Minesweeper
{
    public static void Main()
    {
        const byte SIZE = 2; 
        ushort[] size = new ushort[SIZE];
        
        do
        {
            string[] numbers = Console.ReadLine().Split();
            size[0] = Convert.ToUInt16(numbers[0]);
            size[1] = Convert.ToUInt16(numbers[1]);
            
            if (size[0] != 0 && size[1] != 0)
            {
                byte totalMines = 0;
                
                char[,] table = new char[size[1],size[0]];
                
                for (int row = 0; row < size[1]; row++)
                {
                    string data = Console.ReadLine();
                    for (int column = 0; column < size[0]; column++)
                    {
                        table[row,column] = Convert.ToChar(data[column]);
                    }
                }
                
                for (int row = 0; row < size[1]; row++)
                {
                    for (int column = 0; column < size[0]; column++)
                    {
                        if (row > 0 && column > 0 &&
                            row < size[1]-1 && column < size[0]-1)
                        {
                            if (table[row,column] == '-')
                            {
                                byte validMines = 0;
                                
                                if (table[row,column-1] == '*')
                                {
                                    validMines++;
                                }
                                if (table[row,column+1] == '*')
                                {
                                    validMines++;
                                }
                                if (table[row+1,column] == '*')
                                {
                                    validMines++;
                                }
                                if (table[row+1,column-1] == '*')
                                {
                                    validMines++;
                                }
                                if (table[row+1,column+1] == '*')
                                {
                                    validMines++;
                                }
                                if (table[row-1,column] == '*')
                                {
                                    validMines++;
                                }
                                if (table[row-1,column-1] == '*')
                                {
                                    validMines++;
                                }
                                if (table[row-1,column+1] == '*')
                                {
                                    validMines++;
                                }
                                
                                if (validMines >= 6)
                                    totalMines++;
                            }
                        }
                    }
                }
                Console.WriteLine(totalMines);
            }
            
        }while(size[0] != 0 && size[1] != 0);
    }
}
