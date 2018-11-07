// Ivan Lazcano Sindin
// Name of a month
using System;
class MainClass
{
    public static void Main(string[] args)
    {
        string[] months = { 
            "January", "February", "March", 
            "April", "May", "June", 
            "July", "August", "September", 
            "October", "November","December"};
        Console.Write("Enter a month number: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your month is: {0}", months[m-1]);
    }
}

