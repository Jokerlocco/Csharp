// Queue, first example
// María González Martínez

using System;
using System.Collections;

class Queue1b
{
    static void Main()
    {
        Queue q = new Queue();
        
        string data;
        do
        {
            data = Console.ReadLine();
            if (data != "")
                q.Enqueue(data);
        }
        while (data != "");
        
        int max = q.Count;
        for (int i = 0; i < max; i++)
        {
            Console.WriteLine(q.Dequeue());
        }
    }
}
