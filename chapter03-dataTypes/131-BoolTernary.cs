// Ivan Lazcano Sindin
// Bool + ternary
using System;

public class BoolTernary
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        bool bothEven;
        
        if ((a % 2 == 0) && (b % 2 == 0))
            bothEven = true;
        else
            bothEven = false;
        Console.WriteLine(bothEven);

        bothEven = (a % 2 == 0) && (b % 2 == 0) ? true : false;
        Console.WriteLine(bothEven);
        
        bothEven = (a % 2 == 0) && (b % 2 == 0);
        Console.WriteLine(bothEven);
    }
}
