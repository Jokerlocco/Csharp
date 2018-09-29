// María González Martínez
// Times Table

using System;
public class TimesTable
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i <= 10; i++)
            Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
    }
}
    
