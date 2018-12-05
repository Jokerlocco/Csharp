//Ivan Lazcano
using System;

public class FunctionIsInteger1
{
    public static bool IsInteger(string n)
    {
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] < '0' || n[i] > '9')
                return false;
        }
        return true;
    }

    public static void Main()
    {
        Console.Write(IsInteger("123s123"));
    }
}
