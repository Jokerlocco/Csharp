//Ivan Lazcano Sindin

using System;

public class ContainsAndContainsR
{
    public static bool Contains(string s, char c)
    {
        foreach(char l in s.ToLower())
        {
            if (l == c)
                return true;
        }
        return false;
    }

    public static bool ContainsR(string s, char c)
    {
        //Console.WriteLine(s);
        if (s.ToLower()[s.Length - 1] == c)
            return true;
        else if (s.Length == 1)
            return false;
        
        return ContainsR(s.Remove(s.Length-1), c);
    }
    
    public static void Main(string[] args)
    {
        if (Contains("Hola", 'a')) Console.WriteLine("Hay una A");

        Console.WriteLine(ContainsR("Hola", 'b'));
    }
}
