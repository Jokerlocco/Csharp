// Sergio Ruescas
// Days in a month

using System;

class ArrayMonths
{
    static void Main()
    {
        int[] Months = {
            31,28,31,30,31,30,
            31,31,30,31,30,31};
            
        Console.Write("Enter the number of the month: ");
        int monthNumber = Convert.ToInt32( Console.ReadLine()) ;

        Console.WriteLine("The month {0} has {1} days", 
            monthNumber, Months[monthNumber-1]);
    }
}
