// Ivan Lazcano Sindin
// This program asks for 2 numbers 
//   and says which one is the greatest

/*
Enter a number: 7
Enter another number: 2185
The second one is the greatest
*/

using System;

public class Greatest
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        if ( num1 > num2 )
            Console.WriteLine("The first one is the greatest");
        else if( num2 == num1 )
            Console.WriteLine("They are the same number");
        else
            Console.WriteLine("The second one is the greatest");
    }
    
}
