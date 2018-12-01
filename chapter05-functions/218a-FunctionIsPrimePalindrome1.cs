// Function IsPrime
// First approach, slow, not timed

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
        Console.Write("Enter the lower limit: ");
        long lower = Convert.ToInt64(Console.ReadLine());
        Console.Write("Enter the upper limit: ");
        long upper = Convert.ToInt64(Console.ReadLine());

        long amountFound = 0;
        for (long i = lower; i <= upper; i++)
            if (IsPrimePalindrome(i))
                amountFound++;
        
        Console.WriteLine("Found: "+ amountFound);
    }
}
