//Kevin Marín Romero

using System;

public class Binary
{
    public static void Main()
    {
        const int SIZE = 8;
        byte number, count = 0;
        byte[] binaryDigits = new byte[SIZE];

        Console.Write("Enter a positive number: ");
        number = Convert.ToByte(Console.ReadLine());

        while (number >= 1)
        {
            binaryDigits[count] = (byte)(number % 2);
            count++;
            number /= 2;
        }
        for (int i = SIZE - 1; i >= 0; i--)
        {
            Console.Write(binaryDigits[i]);
        }
    }
}
