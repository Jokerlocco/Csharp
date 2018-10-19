// Jorge Calzada Asenjo
// Statistics3: Sum, average, max, min (a: while)

using System;

public class Statistics3
{
    public static void Main()
    {
        double num, total = 0, min, max;
        int count = 0;

        Console.Write("Data: ");
        num = Convert.ToDouble(Console.ReadLine());

        min = num;
        max = num;

        while (num != 0)
        {
            count++;
            total += num;
            Console.WriteLine(
                "Max = {0}, Min = {1}, Suma = {2}, Media = {3}", 
                max, min, total, total / count);

            Console.Write("Data: ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }
        Console.WriteLine("Bye!");
    }
}
