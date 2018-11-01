// Daniel Contreras
// Days in the week (v1: obtain one item from an array)

using System;

class DaysInTheWeek
{
    static void Main()
    {
        Console.Write("Enter day of week: ");
        int day = Convert.ToInt32(Console.ReadLine());
        
        string[] daysWeek = new string [7];
        daysWeek[0] = "Monday";
        daysWeek[1] = "Tuesday";
        daysWeek[2] = "Wednesday";
        daysWeek[3] = "Thursday";
        daysWeek[4] = "Friday";
        daysWeek[5] = "Saturday";
        daysWeek[6] = "Sunday";

        Console.Write(daysWeek[day - 1]);
    }
}
