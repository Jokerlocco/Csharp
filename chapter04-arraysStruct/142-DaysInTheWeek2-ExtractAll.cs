// Ivan Lazcano Sindin
// Days in the week (v2: extract all the items)

using System;

public class DaysInTheWeek2
{
    public static void Main()
    {
        string[] daysWeek = new string [7];
        daysWeek[0] = "Monday";
        daysWeek[1] = "Tuesday";
        daysWeek[2] = "Wednesday";
        daysWeek[3] = "Thursday";
        daysWeek[4] = "Friday";
        daysWeek[5] = "Saturday";
        daysWeek[6] = "Sunday";

        for (int i = 6; i >= 0; i--)
        {
            Console.Write(daysWeek[i] + " ");
        }

    }
}
