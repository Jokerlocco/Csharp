// Manuel Lago

using System;

public class Ascii
{
    public static void Main()
    {
        Console.WriteLine( Convert.ToInt32("1") );
        Console.WriteLine( Convert.ToInt32('1') );
        
        Console.Write("Enter a char: ");
        char c = Convert.ToChar( Console.ReadLine() );
        
        int ascii = Convert.ToInt32(c);
        Console.WriteLine("Its ASCII code is: " + ascii);
        
        
        if (c >= '0' && c <= '9')
        {
            Console.WriteLine("Its numeric value is: {0} ", 
                ascii - 48);
            Console.WriteLine("Its numeric value is: " + 
                (ascii - 48));
            Console.WriteLine("Its numeric value is: " + 
                (ascii - '0'));
        }
        
        for (int i = 32; i <= 127; i++)
        {
            Console.Write(i + "=" + Convert.ToChar(i) + "  ");
        }
    }
}
