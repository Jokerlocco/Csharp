// GreatestOfThree (v1)
// Daniel Contreras

using System;

public class IsTheGreatestOfThree
{
    public static void Main()
    {
        Console.Write("Enter number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
       
        if ((num1 >= num2) && (num1 >= num3))
            Console.WriteLine("{0} is the greatest", num1);
        else if ((num2 >= num1) && (num2 >= num3))
            Console.WriteLine("{0} is the greatest", num2);
       else
            Console.WriteLine("{0} is the greatest", num3);
   }
}
