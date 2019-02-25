// Stack + Enumerator

using System;
using System.Collections;

public class StackEnumerator
{
    public static void Main()
    {
        string answer;
        Stack myStack = new Stack();
        
        // Let's store data
        do
        {
            Console.Write("Enter an integer: ");
            answer = Console.ReadLine();
            if (answer != "")
                myStack.Push( Convert.ToInt32( answer) );
        }
        while (answer != "");
        
        // Now, let's traverse those data
        bool is5there = false;
        IEnumerator myEnumerator = myStack.GetEnumerator();
        while (myEnumerator.MoveNext())
        {
            int data = (int) myEnumerator.Current;
            if (data == 5)
                is5there = true;
            Console.Write("{0} ", data);
        }
        if (is5there)
            Console.WriteLine("And 5 was there");
        else
            Console.WriteLine();
        
        // Alternative way
        foreach(int data in myStack)
            Console.Write("{0} ", data);
        Console.WriteLine();

        // And the conventional way  ;-)
        while (myStack.Count > 0)
            Console.Write("{0} ", myStack.Pop());
    }
}
