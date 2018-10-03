// Multiple of 2 and 3? (v1: switch)

using System;

public class MultipleOf2And3
{
    public static void Main()
    {
        int n;

        Console.Write("Enter a number (1 to 10): ");
        n = Convert.ToInt32(Console.ReadLine());
        
        switch ( n )
        {
            case 1: Console.WriteLine("Is not a multiple of 2 nor 3"); break;
            case 2: Console.WriteLine("Is a multiple of 2"); break;
            case 3: Console.WriteLine("Is a multiple of 3"); break;
            case 4: goto case 2;
            case 5: goto case 1;
            case 6: Console.WriteLine("Is a multiple of 2 and 3"); break;
            case 7: goto case 1;
            case 8: goto case 2;
            case 9: goto case 3;
            case 10: goto case 2;
            default: Console.WriteLine("Not a valid number"); break;
        }
    }
}
