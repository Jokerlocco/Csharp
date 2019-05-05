// Adrián Navarro Gabino

/*
Challenge 10.01 - Sequence length and minimum (ZIIO)

You are given a sequence of integers, separated with commas.  You are allowed 
to pick some contiguous segment of this sequence (that is, a segment without 
any gaps), and multiply the length of this segment by the minimum number in the 
segment.  What is the maximum value that you can generate in this manner?

For example, suppose the given sequence is 7,2,8,10.  If you pick the entire 
sequence,the length is 4 and the minimum number is 2,  so the product is 8.  If 
you pick the segment 8,10, the length is 2 and the minimum number is 8, so the 
product is 16.  This is the maximum value you can generate for this sequence.  
Note that you cannot pick 7,8,10, since it is not a contiguous segment


Example input

7,2,8,10

Ouput for that input

16


In each of the cases below, you are given a sequence of values and you have to 
determine the maximum value that you can generate by picking a contiguous 
segment and multiplying its length by the minimum number in the segment.


(a) 5,14,8,7,6,10,10,4,2,5,30
(b) 24,22,16,18,6,7,17,16,5,20,8,19,16
(c) 15,30,23,1,47,23,3,8,9,10,19,21,13,5,4

(Source: Zonal Indian Informatics Olympiad, 2013, Problem 2)
*/

using System;
using System.Linq;

class SequenceLengthAndMinimum
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(',');

        int maxLengthAndMinimum = 0;

        for (int i = 1; i <= input.Length; i++)
        {
            int[] numbers = new int[i];

            for(int j = 0; j < input.Length - i + 1; j++)
            {
                for(int k = 0; k < i; k++)
                {
                    numbers[k] = Convert.ToInt32(input[j + k]);
                }

                if (numbers.Min() * numbers.Length > maxLengthAndMinimum)
                    maxLengthAndMinimum = numbers.Min() * numbers.Length;
            }
        }

        Console.WriteLine(maxLengthAndMinimum);
    }
}
