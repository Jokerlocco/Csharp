// Adrián Navarro Gabino

using System;

public class HexToDec
{
    public static void Main()
    {
        Console.Write("Hex number? ");
        string hex = Console.ReadLine();
        
        Console.WriteLine("In base 10 it becomes " + 
            Convert.ToInt32(hex, 16));
    }
}
