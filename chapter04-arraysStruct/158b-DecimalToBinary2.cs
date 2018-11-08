// Decimal to binary (V2)

using System;

public class Binary
{
    public static void Main()
    {
        const int SIZE = 8;
        byte number;
        byte[] binaryDigits = new byte[SIZE];

        Console.Write("Enter a positive number: ");
        number = Convert.ToByte(Console.ReadLine());

        for (int i = 0; i < SIZE; i++)
        {
            binaryDigits[SIZE-1-i] = (byte)(number % 2);
            number /= 2;
        }
        
        for (int i = 0; i < SIZE; i++)
        {
            Console.Write(binaryDigits[i]);
        }
    }
}
