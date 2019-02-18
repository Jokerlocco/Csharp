using System;
using System.Collections.Generic;

class StackOfDoubles2
{
    public static void Main()
    {
        const int SIZE = 10;
        Stack<double> myStack = new Stack<double>();

        for (int i = 0; i < SIZE; i++)
        {
            Console.WriteLine("Enter data "+ (i+1));
            myStack.Push(Convert.ToDouble(Console.ReadLine()));
        }

        // First data, as an extra case
        double data = myStack.Pop();
        Console.WriteLine(data);
        double max = data;

        // Rest of the data
        for (int i = 1; i < SIZE; i++)
        {
            data = myStack.Pop();
            Console.WriteLine(data);
            if (data > max)
                max = data;
        }
        Console.WriteLine("Max = "+ max);
    }
}
