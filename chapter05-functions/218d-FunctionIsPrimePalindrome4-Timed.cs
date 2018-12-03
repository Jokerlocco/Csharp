// Function IsPrime
// Third approach, faster, timed:
//    10.000 to 20.000: 0.006" on i7 7700HQ
//    100.000 to 200.000: 0:00.020" on i7 7700HQ
//    1.000.000 to 2.000.000: 0:00.073" on i7 7700HQ
//    100.000.000 to 200.000.000: 0:07.585" on i7 7700HQ

using System;

public class PrimePalindrome
{
    public static bool IsPrime(long number)
    {
        long limit = (int) Math.Sqrt(number);
        for (int i = 2; i < limit; i++)
        {
            if(number % i == 0)
                return false;
        }
        return true;
    }

    public static bool IsPalindrome(string entry)
    {
        long limit = entry.Length/2;
        for (int i = 0; i < limit; i++)
        {
            if(entry[i] != entry[entry.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsPrimePalindrome(long number)
    {
        if (IsPalindrome(number.ToString()) && IsPrime(number))
            return true;
        else
            return false;
    }

    
    public static void Main()
    {
        DateTime start, end;

        Console.Write("Enter the lower limit: ");
        long lower = Convert.ToInt64(Console.ReadLine());
        Console.Write("Enter the upper limit: ");
        long upper = Convert.ToInt64(Console.ReadLine());

        start = DateTime.Now;

        long amountFound = 0;
        for (long i = lower; i <= upper; i++)
            if (IsPrimePalindrome(i))
                amountFound++;

        end = DateTime.Now;
        Console.WriteLine("Found: "+ amountFound);
        Console.WriteLine("Time taken: "+ (end-start) );
    }
}
