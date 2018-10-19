//Ivan Lazcano
using System;
class AbbreviatedOperations
{
    public static void Main()
    {
        Console.Write("Enter a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter c:");
        int c = Convert.ToInt32(Console.ReadLine());
        
        a++;
        Console.WriteLine("a incremented: {0}", a++);
            
        b /= 3;
        Console.WriteLine("b divided by 3: {0}", b);
        
        c -= 5;
        Console.WriteLine("c reduced by 5: {0}", c);
        
        int d1 = 8, e1 = 8;
        Console.WriteLine("d1 = {0}, e1 = {1}", d1, e1);
        int d2 = --d1;
        int e2 = e1--;
        Console.WriteLine("After decrementing, d1 = {0}, e1 = {1}", d1, e1);
        Console.WriteLine("Predecrementing d1, d2 = {0}", d2);
        Console.WriteLine("Postdecrementing d2, e2 = {0}", e2);
    }
}
