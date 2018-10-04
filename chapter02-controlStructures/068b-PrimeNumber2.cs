// Jorge Calzada Asenjo
// Finding out if a number is prime

using System;

public class PrimeNumbers
{
    public static void Main()
    {
        int num;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int divider = 2; divider <= num; divider++)
        {
            if (num % divider == 0 && divider != num)
            {
                Console.WriteLine("{0} is not a prime number", num);
                break;
            }
            else if (divider == num)
                Console.WriteLine("{0} is a prime number", num);
        }
    }
}
