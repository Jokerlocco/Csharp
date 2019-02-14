// Stack 01a
// Jorge Calzada Asenjo

using System;
using System.Collections;

class Stacks
{
    static void Main()
    {
        Stack s = new Stack();

        string data = Console.ReadLine();

        while (data != "")
        {
            s.Push(data);
            data = Console.ReadLine();
        }

        while (s.Count > 0)
        {
            Console.WriteLine(s.Pop());
        }
    }
}
