// IsLeapYear
// Miguel Pastor

using System;

public class LeapYear
{
    public static void Main()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        if (IsLeapYear(year) == true)
            Console.WriteLine(year + " was a leap year");
    }
    
    public static bool IsLeapYear(int year)
    {
        if(year % 4 == 0)
        {
            if(year % 100 == 0)
                return false;
            else
                return true;
        }
        return false;
    }
}
