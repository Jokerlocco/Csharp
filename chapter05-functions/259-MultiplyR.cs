/*
Functions Multiply and MultiplyR

Create two functions, Multiply and MultiplyR, to calculate the product 
of two non-negative integer numbers using sums. The first version must 
be iterative, and the second one must be recursive.
*/

//Pablo Sánchez Alonso

using System;

class Exercise259
{
    public static int Multiply(int num1, int num2)
    {
        int product = 0;

        for (int i = 0; i < num2; i++)
        {
            product += num1;
        }
        return product;
    }
    
    public static int MultiplyR(int num1, int num2)
    {
        
        int product;

        if (num2 == 0)
        {
            return 0;
        }
        
        else
        {
            product = num1 + MultiplyR(num1, num2 - 1);
        }

        return product;
    }

    static void Main()
    {
        Console.WriteLine("Iterative: " + Multiply(5,10));
        Console.WriteLine();
        Console.WriteLine("Recursive: " + MultiplyR(5,10));
        Console.WriteLine();
    }
}       
