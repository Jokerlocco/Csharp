// María González Martínez
// Function Double (no ref parameters)

using System;
public class FunctionDouble
{
    public static int Double(int num)
    {
        return num * 2;
    }
    
    public static void Main()
    {
        int num = 3;
        Console.WriteLine(num);
        Console.WriteLine(Double(num));
    }
}
