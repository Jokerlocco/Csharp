// María González Martínez
// Seconds to hours, minutes & seconds

using System;
public class Hours
{
    public static void Main()
    {
        int totalSeconds, hours, minutes, seconds;
        Console.Write("How many seconds? ");
        totalSeconds = Convert.ToInt32(Console.ReadLine());

        hours = totalSeconds / 3600;
        minutes = (totalSeconds % 3600) / 60;
        seconds = (totalSeconds % 3600) % 60;

        Console.WriteLine("{0}h {1}m {2}s ", hours,minutes,seconds);
    }
}
