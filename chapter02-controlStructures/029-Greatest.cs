// Program that collects two numbers
//   and finds out which is the greatest
// Daniel Contreras

/*
Enter first number: 7
Enter second number: 2185
2185 is the greatest
*/


using System;

public class BiggerNumber
{
    public static void Main()
    {
        int num1, num2;

        Console.WriteLine("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
            Console.WriteLine("{0} is the greatest", num1);
        else
            Console.WriteLine("{0} is the greatest", num2);
    }
}
