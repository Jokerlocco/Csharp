// Decimal to binary (V3)

using System;

public class Binary
{
    public static void Main()
    {
        const int SIZE = 8;
        byte number;
        string binary = "";

        Console.Write("Enter a positive number: ");
        number = Convert.ToByte(Console.ReadLine());

        for (int i = 0; i < SIZE; i++)
        {
            binary = (byte)(number % 2) + binary;
            number /= 2;
        }
        
        Console.WriteLine(binary);
    }
}
