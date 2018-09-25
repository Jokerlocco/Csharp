// Division of 2 numbers. The second can't be 0
// Diego Anibal Lezcano Reissner

using System;

public class Division 
{    
    public static void Main ()
    {
        int a, b;
        
        Console.Write("Enter a number: ");
        a = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter another number: ");
        b = Convert.ToInt32(Console.ReadLine());
        
        while(b==0)
        {
            Console.WriteLine("The second number can't be 0");
            Console.Write("Enter another number: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("The division is {0}",a/b);
    }
}
