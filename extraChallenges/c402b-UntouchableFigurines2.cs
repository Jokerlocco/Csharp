//Kevin Marín Romero

using System;

public class FiguritasIntocables
{
    public static void Main()
    {
        const byte SIZE = 2;
        byte[] numbers = new byte[SIZE];
        byte cases = Convert.ToByte(Console.ReadLine());
        
        for (int i = 0; i < cases; i++)
        {
            string[] data = Console.ReadLine().Split();
            
             numbers[0] = Convert.ToByte(data[0]);
             numbers[1] = Convert.ToByte(data[1]);
             
            char[,] table = new char[numbers[1],numbers[0]];
             
            for (int row = 0; row < numbers[1]; row++)
            {
                string line = Console.ReadLine();
                
                for (int column = 0; column < numbers[0]; column++)
                {
                    table[row,column] = Convert.ToChar(line[column]);
                }
            }
            
            bool isValid = false;
            
            for (int row = 0; row < numbers[1]; row++)
            {
                for (int column = 0; column < numbers[0]; column++)
                {
                    if (table[row,column] == 'F')
                    {
                        if ((column != 0) && (column != numbers[0]-1) &&
                            (row != 0) && (row != numbers[1]-1))
                        {
                            if (table[row,column-1] == 'X' &&
                                table[row,column+1] == 'X' &&
                                table[row-1,column] == 'X' &&
                                table[row+1,column] == 'X' &&
                                table[row+1,column-1] == 'X' &&
                                table[row+1,column+1] == 'X' &&
                                table[row-1,column-1] == 'X' &&
                                table[row-1,column+1] == 'X')
                            {
                                isValid = true;
                            }
                            else
                            {
                                isValid = false;
                                break;
                            }
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }                    
                }
            }
            
            if (isValid)
            {
                Console.WriteLine("VALIDA");
            }
            else
            {
                Console.WriteLine("INVALIDA");
            }
        }
       
    }
}
