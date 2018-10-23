// Manuel Lago
// Byte to hex

using System;

public class DecimalHexadecimal
{
    public static void Main()
    {
        char letter;
        
        Console.Write("Número? ");
        byte num = Convert.ToByte( Console.ReadLine() );
        
        int div = num / 16;
        
        int res = num % 16;
        
        Console.Write("En hex es ");
        
        if (div >= 10)
        {
            switch (div)
            {
                case 10: letter = 'A'; Console.Write(letter);break;
                case 11: letter = 'B'; Console.Write(letter);break;
                case 12: letter = 'C'; Console.Write(letter);break;
                case 13: letter = 'D'; Console.Write(letter);break;
                case 14: letter = 'E'; Console.Write(letter);break;
                case 15: letter = 'F'; Console.Write(letter);break;
            }
        }
        else
            Console.Write(div);
            
        if ( res >= 10 )
        {
            switch (div)
            {
                case 10: letter = 'A'; Console.Write(letter);break;
                case 11: letter = 'B'; Console.Write(letter);break;
                case 12: letter = 'C'; Console.Write(letter);break;
                case 13: letter = 'D'; Console.Write(letter);break;
                case 14: letter = 'E'; Console.Write(letter);break;
                case 15: letter = 'F'; Console.Write(letter);break;
            }
        }
        else
            Console.Write(res);
    }
}
