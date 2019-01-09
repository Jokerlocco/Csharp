// Greatest digit of a long integer number
// José Vicente Antón Castelló

using System;

class Program
{
    static byte GreatestDigit(long number)
    {
        string numberAsString = number.ToString();
        int biggestFigure = Convert.ToInt32(
            numberAsString.Substring(0,1));

        for (int i = 1; i < numberAsString.Length; i++)
        {
            int current = 
                Convert.ToInt32(numberAsString.Substring(i,1));

            if (current > biggestFigure)
                biggestFigure = current;
        }

        return (byte) biggestFigure; 
    }

    static void Main(string[] args)
    {
        Console.Write(GreatestDigit(32)); // Should display 3

        if (GreatestDigit(276) != 7)
            Console.WriteLine("Something is not right!");
    }
}
