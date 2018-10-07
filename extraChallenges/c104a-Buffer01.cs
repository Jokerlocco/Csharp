// Kevin Marín Romero
// The buffer

// Jorge Calzada Asenjo
// Challenge 1.04 - The Buffer

/*
How many men can use wall-mounted urinals at the same time without breaking
the rule that one must always leave a buffer between a urinal and other
urinal?
*/

/*
Example of entry:
5
1
2
3
4
5

Output for that example:
1
1
2
2
3
*/

using System;

public class Buffer
{
    public static void Main()
    {
        int amount, num, count;
        amount = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < amount; i++)
        {
            num = Convert.ToInt32(Console.ReadLine());
            count = 0;
            
            for (int j = 0; j < num; j = j +2)
                count++;
            Console.WriteLine(count);
        }
        Console.WriteLine();
    }
}
