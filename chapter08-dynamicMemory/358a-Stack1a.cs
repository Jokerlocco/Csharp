// Stack 01b
// Kevin Marín Romero

using System;
using System.Collections;

class Stacks
{
    static void Main(string[] args)
    {
        Stack s = new Stack();

        string data;

        do
        {
            data = Console.ReadLine();
            if(data != "")
            {
                s.Push(data);
            }
        } 
        while (data != "");

        int max = s.Count;
        Console.WriteLine();
        for (int i = 0; i < max; i++)
        {
            Console.WriteLine(s.Pop());
        }
    }
}
