// Stack of strings using a List<string> 
// (version 2)

using System;
using System.Collections.Generic;

public class StackStr
{
    private List<string> data;
    
    public StackStr()
    {
        data = new List<string>();
    }
    
    public void Push(string s)
    {
        data.Insert(0, s);
    }
    
    public string Pop()
    {
        string s = data[0];
        data.RemoveAt(0);
        return s;
    }
    
    public string Peek()
    {
        return data[0];
    }
    
    public int Count
    {
        get { return data.Count; }
    }
}


public class StackStrTest
{
    public static void Main()
    {
        StackStr myStack = new StackStr();
        
        for (int i = 1; i <= 3; i++)
        {
            myStack.Push("data " + i);
        }
        
        Console.WriteLine(myStack.Peek());
        Console.WriteLine(myStack.Count);
        Console.WriteLine();
        while (myStack.Count > 0)
            Console.WriteLine(myStack.Pop());
    }
}
