// Jorge Calzada Asenjo
// Seconds to HH:MM:SS

using System;

public class ToHHMMSS
{
    public static void Main()
    {
        string timeString;
        int time, h, m, s;

        Console.Write("Seconds? ");
        timeString = Console.ReadLine();

        while (timeString != "")
        {
            time = Convert.ToInt32(timeString);
            m = time / 60;
            s = time % 60;
            h = m / 60;
            m = m % 60;

            Console.WriteLine("{0}:{1}:{2}", 
                h.ToString("00"), 
                m.ToString("00"), 
                s.ToString("00"));

            Console.Write("Seconds? ");
            timeString = Console.ReadLine();
        }
    }
}
