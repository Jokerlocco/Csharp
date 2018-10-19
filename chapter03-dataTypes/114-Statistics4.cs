// Jorge Calzada Asenjo
// Statistics4: Sum, average, max, min, "end" to endish

using System;

public class Statistics4
{
    public static void Main()
    {
        double num, total = 0, min = 0, max = 0;
        int count = 0;

        Console.Write("Data: ");
        string answer = Console.ReadLine();
        if (answer != "end")
        {
            num = Convert.ToDouble( answer );

            min = num;
            max = num;
        }

        while (answer != "end")
        {
            num = Convert.ToDouble( answer );
            if (num < min)
                min = num;
            if (num > max)
                max = num;            
            
            count++;
            total += num;
            Console.WriteLine(
                "Max = {0}, Min = {1}, Sum = {2}, Average = {3}", 
                max, min, total, total / count);

            Console.Write("Data: ");
            answer = Console.ReadLine();
        }
        Console.WriteLine("Bye!");
    }
}
