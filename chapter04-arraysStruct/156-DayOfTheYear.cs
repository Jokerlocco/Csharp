// Araceli Yáñez Muñoz

using System;

public class DayOfTheYear
{
    public static void Main()
    {
        int[] months = {31, 28, 31, 30, 31, 30, 
            31, 31, 30, 31, 30, 31};
        int sum = 0; 
        
        Console.Write("Enter the number of month (1 to 12): ");
        int numberMonth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of day: ");
        int numberDay = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0 ;i < numberMonth-1 ; i++)
            sum += months[i];
        sum += numberDay;
        
        Console.WriteLine("Is the day number {0} of the year", sum);
    }
}
