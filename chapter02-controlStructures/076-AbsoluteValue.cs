// María González Martínez

using System;
public class AbsoluteValue
{
    public static void Main()
    {
        int n, absolute;
        
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        // With "if"
        if (n > 0)
            absolute = n;
        else
            absolute = -n ;
        
        // With the ternary operator
        absolute = n > 0 ? n : -n ;
        
        Console.WriteLine(absolute);
    }
}
