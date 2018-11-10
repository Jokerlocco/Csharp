using System;

public class Uppercase
{
    public static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        // Note: the next line does not work,
        // we must save the changes
        // name.ToUpper();
        
        // This is the correct way
        name = name.ToUpper();
        
        Console.Write("Now your name is: ");
        Console.WriteLine(name);
    }
}
