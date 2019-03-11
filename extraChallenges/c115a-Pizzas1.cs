//Ivan Lazcano Sindin

/*
Input sample

3
3
8 8 8
2
5 3
4
3 4 5 6

Output sample

Case #1: 3
Case #2: 1
Case #3: 3
*/

using System;

class Pizzas
{
    public static void Main(string[] args)
    {
        int total;

        int count = Convert.ToInt32(Console.ReadLine());
        for(int i=1; i<=count; i++)
        {
            int persons = Convert.ToInt32(Console.ReadLine());

            string[] numbers = Console.ReadLine().Split();
            total = 0;
            for (int p = 0; p < persons; p++)
            {
                total += Convert.ToInt32(numbers[p]);
            }
            Console.Write("Case #" + i + ": ");
            if(total % 8 != 0)
                Console.WriteLine(total / 8 + 1);
            else
                Console.WriteLine(total/8);
        }
    }
}

