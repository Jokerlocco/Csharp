// Integer digits and most significant digit
// Javier Benajes

using System;

public class FunctionGetDigits
{

    public static void GetDigits(double n, 
        ref int integerDigits, ref int mostSignificant)
    {
        string number = Convert.ToString(n);
        int count = 0;

        while (count < number.Length && number[count] != ',')
        {
            count++;
        }

        integerDigits = count;
        mostSignificant = number[0] - 48;
    }

    public static void Main()
    {
        int integerDigits = 0;
        int mostSignificant = 0;

        GetDigits(236.78, ref integerDigits, ref mostSignificant);
        Console.WriteLine("Integer digits: " + integerDigits + 
            ", MSD: " + mostSignificant);
            
        GetDigits(0.78, ref integerDigits, ref mostSignificant);
        Console.WriteLine("Integer digits: " + integerDigits + 
            ", MSD: " + mostSignificant);
            
        GetDigits(5, ref integerDigits, ref mostSignificant);
        Console.WriteLine("Integer digits: " + integerDigits + 
            ", MSD: " + mostSignificant);
    }
}
