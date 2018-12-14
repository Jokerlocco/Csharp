// Kevin Marín Romero
// LookingForTheTen

/*

Sample inputs

9,10,10,9
8,9
0,0,0,0,0,0,0,0,0,0,0,0,0
10,10,10,10
7,7,10,10,4,6,4,6,0,6,7,4,6,6,9

Outputs for those inputs

0
4
247
0
101

*/

using System;

public class LookingForTheTen
{
    public static void Main()
    {
        string[] data = Console.ReadLine().Split(',');
        int[] numbers = new int[data.Length];
        int sumNumbers = 0;
        int totalTens = 0;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(data[i]);
            sumNumbers += numbers[i];
        }
        
        while (((sumNumbers + (totalTens*10)) / 
            ((float)numbers.Length + totalTens)) < 9.5)
        {
            totalTens++;
        }
        
        Console.WriteLine(totalTens);
    }
}
