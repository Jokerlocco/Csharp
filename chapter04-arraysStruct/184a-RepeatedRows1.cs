// José Vicente Antón Castelló

using System;

public class Array
{
    public static void Main()
    {
        const int SIZE = 3;
        float[,] matriz = new float [SIZE,SIZE];
        
        for(int i = 0; i < SIZE; i++)
        {
            for(int j = 0; j < SIZE; j++)
            {
                Console.Write
                    ("Enter number for row {0} and column {1}: ", i + 1, j + 1);
                matriz[i,j] = Convert.ToSingle(Console.ReadLine());
            }
        }
        
        if ((matriz[0,0] == matriz [1,0]
                && matriz[0,1] == matriz [1,1]
                && matriz[0,2] == matriz [1,2])
            || (matriz[0,0] == matriz [2,0]
                && matriz[0,1] == matriz [2,1]
                && matriz[0,2] == matriz [2,2])
            || (matriz[1,0] == matriz [2,0]
                && matriz[1,1] == matriz [2,1]
                && matriz[1,2] == matriz [2,2]))
        {
            Console.WriteLine("A row is duplicated"); 
        }
    }
}
