// Countdown from 30 to 0, step 3
// Daniel Contreras

using System;
public class From30To0
{
    public static void Main()
    {
        for (int i = 30; i >= 0; i = i-3)
            Console.Write("{0} ", i);
        Console.WriteLine();
    }
}
