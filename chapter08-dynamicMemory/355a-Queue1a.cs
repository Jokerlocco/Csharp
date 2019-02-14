// Queue, first example
// Cristina Francés

using System;
using System.Collections;

class Queue1a
{
    static void Main()
    {
        Queue q = new Queue();
        
        string data = Console.ReadLine();
                
        while(data != "")
        {
            q.Enqueue(data);
            data = Console.ReadLine();
        }
        
        while(q.Count > 0)
        {
            Console.WriteLine(q.Dequeue());
        }
    }
}
