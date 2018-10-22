// Ivan Lazcano Sindin
// Payment in a garage

using System;

class MainClass
{
    public static void Main()
    {
        int minutes1, hours1, minutes2, hours2;
        int diferenceHours, diferenceMinutes;
        double toPay;
        Console.WriteLine("Enter time 1: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter time 2: ");
        int b = Convert.ToInt32(Console.ReadLine());

        hours1 = a / 100;
        hours2 = b / 100;
        minutes1 = a % 100;
        minutes2 = b % 100;

        diferenceHours = hours2 - hours1;
        diferenceMinutes = minutes2 - minutes1;

        if (diferenceMinutes >= 0)
            diferenceHours++;

        toPay = 2.20 * diferenceHours;

        Console.WriteLine("{0}", toPay);
    }
}
