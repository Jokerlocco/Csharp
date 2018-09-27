//Ivan Lazcano Sindin  
using System;

public class HelloWorld10
{
    public static void Main()
    {
        int number, sum = 0;
        
        do
        {
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            sum = sum + number;
        }
        while ( number != 0 );
        
        Console.WriteLine("The total is: {0}", sum);
    }
}
