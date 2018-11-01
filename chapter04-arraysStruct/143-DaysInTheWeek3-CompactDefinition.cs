// Kevin Marín Romero
// Days in the week (v3: compact definition + show reversed)

using System;

public class DaysInTheWeekCompact
{
    public static void Main()
    {
        string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday",
            "Thursday", "Friday", "Saturday", "Sunday"};

        for (int i = daysOfTheWeek.Length - 1; i >= 0; i--)
            Console.Write(daysOfTheWeek[i] + " "); 
    }
}
