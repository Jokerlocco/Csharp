// María González Martínez

using System;
public class FunctionIsInteger2
{
    public static bool IsInteger(string s)
    {
        try
        {
            int num = Convert.ToInt32(s);
        }
        catch(FormatException)
        {
            return false;
        }
        return true;
    }
    
    public static void Main()
    {
        string text = Console.ReadLine();
        
        if(IsInteger(text))
            Console.WriteLine("It is an integer number");
        else
            Console.WriteLine("It is not an integer number");
    }
}
