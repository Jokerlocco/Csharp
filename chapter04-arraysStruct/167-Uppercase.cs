using System;

public class Uppercase
{
    public static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        name = name.ToUpper();
        
        Console.Write("Now your name is: ");
        Console.WriteLine(name);
    }
}
