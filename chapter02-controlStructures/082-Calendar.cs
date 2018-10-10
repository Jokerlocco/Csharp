// José Vicente Antón Castelló
// Calendar

using System;

public class Calendar
{
    public static void Main()
    {
        Console.Write
            ("What is the first day? (Monday = 0, Tuesday = 1, ...) ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("How many days does the month have? ");
        int days = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < first % 7; i++)
            Console.Write("   ");
        for (int i = 1; i <= days; i++)
        {
            if (i < 10)
                Console.Write(" ");
            Console.Write("{0} ", i);
            if ((first + i) % 7 == 0)
                Console.WriteLine();
        }
    }
}
