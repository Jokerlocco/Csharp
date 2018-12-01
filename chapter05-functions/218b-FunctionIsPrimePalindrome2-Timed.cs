// Function IsPrime
// First approach B, slow, timed:
//    10.000 to 20.000: 1.266" on i7 7700HQ
//    100.000 to 200.000: 2:31.309" on i7 7700HQ

using System;

public class PrimePalindrome
{
    public static bool IsPrime(long number)
    {
        int dividers = 0;
        for (int i = 1; i <= number; i++)
        {
            if(number % i == 0)
                dividers++;
        }
        return dividers == 2;	
    }

    public static bool IsPalindrome(string s)
    {
        string reversed = "";
        for(int i = s.Length-1; i >= 0; i--)
        {
            reversed += s[i];
        }
        if (s == reversed)
            return true;
        else
            return false;
    }

    public static bool IsPrimePalindrome(long number)
    {
        if (IsPrime(number) && IsPalindrome(number.ToString()))
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
