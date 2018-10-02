// Jorge Calzada
// Challenge 1.03: "Goteras"

/*
Sample input
3
70
3600
3661
Sample output
00:01:10
01:00:00
01:01:01
*/

using System;

public class Gotas
{
    public static void Main()
    {
        int count, time, h, m, s;

        count = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            time = Convert.ToInt32(Console.ReadLine());

            m = time / 60;
            s = time % 60;
            h = m / 60;
            m = m % 60;

            Console.WriteLine("{0}{1}:{2}{3}:{4}{5}", 
                h < 10 ? "0" : "", h, 
                m < 10 ? "0" : "", m, 
                s < 10 ? "0" : "", s);
        }
    }
}
