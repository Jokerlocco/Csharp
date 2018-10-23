// Ivan Lazcano Sindin
// Byte to hex

using System;

public class MainClass
{
    public static void Main()
    {
        byte result, rest;
        string r2 = " ";
        string r1 = " ";
        Console.Write("Enter a number: ");
        byte number = Convert.ToByte(Console.ReadLine());
        result= Convert.ToByte(number / 16);
        rest = Convert.ToByte(number % 16);

        switch(result)
        {
            case 0:break;
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:r1 = Convert.ToString(result); break;
            case 10: r1 = "A";break;
            case 11: r1 = "B";break;
            case 12: r1 = "C";break;
            case 13: r1 = "D";break;
            case 14: r1 = "E";break;
            case 15: r1 = "F";break;
            default: break;
        }

        switch (rest)
        {
            case 0: break;
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9: r2 = Convert.ToString(rest); break;
            case 10: r2 = "A"; break;
            case 11: r2 = "B"; break;
            case 12: r2 = "C"; break;
            case 13: r2 = "D"; break;
            case 14: r2 = "E"; break;
            case 15: r2 = "F"; break;
            default: break;
        }

        Console.WriteLine("Hex: {0}{1}", r1, r2);
        Console.WriteLine("Hex easy: {0}", number.ToString("X"));
    }
}
