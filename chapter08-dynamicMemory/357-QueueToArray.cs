// Queue + ToArray
// Sergio Ruescas

using System.Collections;
using System;

class QueueToArray
{
    public static void Main()
    {
        string input;
        Queue queue = new Queue();
        do
        {
            input = Console.ReadLine();
            if (input != "" && input != "quit")
            {
                queue.Enqueue(input);
            }
            else
            {
                Object[] queueCopy = queue.ToArray();
                for (int i = 0; i < queueCopy.Length; i++)
                {
                    Console.Write(queueCopy[i] + " ");
                }
                Console.WriteLine();
            }
        }while (input != "quit") ;
        
    }
}

