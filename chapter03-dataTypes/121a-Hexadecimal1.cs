// Kevin Marín Romero
// Byte to hex

using System;

public class ConvertHex
{
    public static void Main()
    {
        byte num;
        int valor, resto;
        Console.Write("Enter a number: ");
        num = Convert.ToByte(Console.ReadLine());
        
        valor = num / 16;
        resto = num % 16;
        
        Console.Write(num + " is in Hex: ");
        
        switch (valor)
        {
            case 10: Console.Write("A"); break;
            case 11: Console.Write("B"); break;
            case 12: Console.Write("C"); break;
            case 13: Console.Write("D"); break;
            case 14: Console.Write("E"); break;
            case 15: Console.Write("F"); break;
            default: Console.Write(valor); break;
        }
        
        switch (resto)
        {
            case 10: Console.Write("A"); break;
            case 11: Console.Write("B"); break;
            case 12: Console.Write("C"); break;
            case 13: Console.Write("D"); break;
            case 14: Console.Write("E"); break;
            case 15: Console.Write("F"); break;
            default: Console.Write(resto); break;
        }
        Console.WriteLine();
        
        // Another way
        
        Console.WriteLine("{0} is in Hex: {1}", num, 
            num.ToString("X"));        
        
        // And another
        
        Console.WriteLine("{0} is in Hex: {1}", num, 
            Convert.ToString(num, 16));        
    }
}
