// Byte to hex, version 4

using System;

public class DecimalHexadecimal
{
    public static void Main()
    {
        char letter;
        
        Console.Write("Number? ");
        byte num = Convert.ToByte( Console.ReadLine() );
        
        int divider = num / 16;        
        int remainder = num % 16;
        
        Console.Write("Hex: ");
        
        if (divider < 10)
            letter = (char) ('0'+divider);
        else
            letter = (char) ('A'+(divider-10));
        Console.Write(letter);
            
        if (remainder < 10)
            letter = (char) ('0'+remainder);
        else
            letter = (char) ('A'+(remainder-10));
        Console.WriteLine(letter);
        
        Console.WriteLine(num.ToString("X2"));
    }
}
