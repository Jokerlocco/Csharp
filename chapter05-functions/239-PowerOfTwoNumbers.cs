using System;

class PowerOfTwoNumbers
{
    static int Power(int b, int e)
    {
        int result = 1;
        
        for (int i = 0; i < e; i++)
        {
            result *= b;
        }
        return result;
    }
    
    static void Main()
    {
        Console.WriteLine("What is the number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("What is the power: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(Power(a, b));
    }
}
