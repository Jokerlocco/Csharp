// Queue, second example
// Manuel Lago

using System;
using System.Collections;

class Queue2
{
    static void Main()
    {
        Queue q = new Queue();
        string text;
        
        do
        {
            text = Console.ReadLine();
            
            if (text == "")
            {
                while (q.Count > 0)
                {
                    Console.WriteLine(q.Dequeue());
                }
            }
            else
            {
                q.Enqueue(text);
            }
        } 
        while(text != "quit");
    }
}
