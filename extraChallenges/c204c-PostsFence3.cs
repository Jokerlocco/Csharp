//Kevin Marín Romero
//Postes para un Cercado

/*
Example of input
10 10 10
6 6 10
10 15 10
0 0 0

Example of output
4
4
6
*/

using System;

public class PostesCercado
{
    public static void Main()
    {
        string[] data = new string[3];
        int[] numbers = new int[3];
        int count;
        do
        {
            count = 0;
            data = Console.ReadLine() .Split();
            
            if (data[0] != "0" && data[1] != "0" && data[2] != "0")
            {
                for (int i = 0; i < data.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(data[i]);
                }
                
                while(numbers[0] > 0)
                {
                    numbers[0] -= numbers[2];
                    count+= 2;
                }
                
                while(numbers[1] > 0)
                {
                    numbers[1] -= numbers[2];
                    count += 2;
                }
                Console.WriteLine(count);
            }
        }
        while (data[0] != "0" && data[1] != "0" && data[2] != "0");
    }
}
