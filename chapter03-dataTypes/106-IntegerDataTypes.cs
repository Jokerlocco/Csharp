using System;

public class IntegerDataTypes
{
    static void Main()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        
        Console.WriteLine("Enter your age:");
        byte age = Convert.ToByte(Console.ReadLine());
        
        Console.WriteLine("Enter the year you wer born:");
        ushort year = Convert.ToUInt16(Console.ReadLine());
        
        Console.WriteLine("Enter the population of your country:");
        ulong population = Convert.ToUInt64(Console.ReadLine());
    }
}
        
  
