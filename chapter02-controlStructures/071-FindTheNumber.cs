// Find the hidden number
// Kevin Marín Romero

using System;

public class HiddenNumber
{
    public static void Main()
    {
        int hidden = 70;
        int num;
        do
        {
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            
            if (num == hidden)
                Console.WriteLine("Congratulations!");
            else if (num > hidden)
                Console.WriteLine("Too Big");
            else
                Console.WriteLine("Too Small");
        }
        while(num != hidden);
    }
}
