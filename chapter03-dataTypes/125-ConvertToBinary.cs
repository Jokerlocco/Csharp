//Jaime Francisco Rebollo Domínguez

using System;

public class ConvertToBinary
{
    public static void Main()
    {
        byte number;
        
        Console.Write("Enter a number: ");
        number = Convert.ToByte( Console.ReadLine() );
        
        Console.WriteLine("In binary it is: {0}",
            Convert.ToString(number, 2));
    }
}
