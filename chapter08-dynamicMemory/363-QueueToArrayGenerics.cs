// Queue + ToArray + Generics

using System.Collections.Generic;
using System;

class QueueToArray
{
    public static void Main()
    {
        string input;
        Queue<string> queue = new Queue<string>();
        do
        {
            input = Console.ReadLine();
            if (input != "" && input != "quit")
            {
                queue.Enqueue(input);
            }
            else
            {
                string[] queueCopy = queue.ToArray();
                for (int i = 0; i < queueCopy.Length; i++)
                {
                    Console.Write(queueCopy[i] + " ");
                }
                Console.WriteLine();
            }
        }while (input != "quit") ;
        
    }
}

