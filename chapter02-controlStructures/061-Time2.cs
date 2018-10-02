// Seconds to hours, minutes & seconds
// V2: Format such as 02:07:09

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

        if (hours < 10)
            Console.Write("0");
        Console.Write(hours);
        
        Console.Write(":");
        
        if (minutes < 10)
            Console.Write("0");
        Console.Write(minutes);
        
        Console.Write(":");
        
        if (seconds < 10)
            Console.Write("0");
        Console.Write(seconds);
        
    }
}
