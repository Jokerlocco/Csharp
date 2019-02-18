using System;
using System.Collections;

class StackOfQueues1
{
    public static void Main()
    {
        const int SIZE = 10;
        Stack myStack = new Stack();

        for (int i = 0; i < SIZE; i++)
        {
            Console.WriteLine("Enter data "+ (i+1));
            myStack.Push(Convert.ToDouble(Console.ReadLine()));
        }

        // First data, as an extra case
        double data = (double) myStack.Pop();
        Console.WriteLine(data);
        double max = data;

        // Rest of the data
        for (int i = 1; i < SIZE; i++)
        {
            data = (double) myStack.Pop();
            Console.WriteLine(data);
            if (data > max)
                max = data;
        }
        Console.WriteLine("Max = "+ max);
    }
}
