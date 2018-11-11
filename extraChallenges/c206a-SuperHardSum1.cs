/*
Reto 2.06: Super hard sum

Your amazing program should calculate the sum of the numbers given in each 
line, and output one line for each question with the response. Numbers can be 
negative, really big and lines contain extra spaces, so make your program 
resistant to input.
 
Your program will need to read from standard input, line by line till the end 
of the input. Consider each line a different question. For each line you read, 
output the sum of all the given numbers.

Sample input and output

Sample input
963123456789012 1
2 3
4   5 -1

Sample output
963123456789013
5
8
*/

//Ivan Lazcano
using System;

class MegaSum
{
    static void Main()
    {
        long sum = 0;
        string[] input;
        do
        {
            sum = 0;
            input = Console.ReadLine().Trim().Replace("  ", " ").Split();
            if (input[0] != "")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != "")
                        sum += Convert.ToInt64(input[i]);
                }
                Console.WriteLine(sum);
            }
        } while (input[0] != "");
    }
}
