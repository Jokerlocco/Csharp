// Jorge Calzada Asenjo
// Challenge 2.03: Calculation machine
// C# version

/*
    Calculates basic operations
*/

/*
Example of input
5
5 + -13
10 / 2
7 * 3
3 / 0
5 - 13

Example of output
-8
5
21
ERROR
-8
*/

using System;

public class CalculationMachine
{
    public static void Main()
    {
        int cases;


        cases = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cases; i++)
        {
            string[] data = Console.ReadLine().Split();

            switch (data[1])
            {
                case "+": Console.WriteLine(
                    Convert.ToInt32(data[0]) + Convert.ToInt32(data[2]));
                    break;
                case "-": Console.WriteLine(
                    Convert.ToInt32(data[0]) - Convert.ToInt32(data[2]));
                    break;
                case "*": Console.WriteLine(
                    Convert.ToInt32(data[0]) * Convert.ToInt32(data[2]));
                    break;
                case "/":
                    if (data[2] == "0")
                    {
                        Console.WriteLine("ERROR");
                    }
                    else
                    {
                        Console.WriteLine(
                            Convert.ToInt32(data[0]) 
                            / Convert.ToInt32(data[2]));
                    }
                    break;
            }
        }
    }
}
