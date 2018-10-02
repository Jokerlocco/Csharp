// Common dividers of two numbers

using System;

public class CommonDividers
{
    public static void Main()
    {
        int n1, n2;

        Console.Write("Enter a number: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        int min = n1;
        if (n2 < min) min = n2;


        Console.Write("Their common dividers are... ");

        for(int i = 2; i <= min; i++)
        {
            if( (n1 % i == 0) && (n2 % i == 0) )
            {
                Console.Write("{0} ", i);
                count++;
            }
        }

        if(count == 0)
            Console.WriteLine(" None");
        else
            Console.WriteLine();
    }
}
