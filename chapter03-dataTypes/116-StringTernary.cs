// José Vicente Antón Castelló
// Ternary operator & strings

using System;

public class TernaryAndString
{
    public static void Main()
    {
        string markAsString;
        
        Console.Write("Enter your mark (0-100): ");
        float mark = Convert.ToSingle(Console.ReadLine());
        
        if (mark >= 60)
            markAsString = "passed";
        else
            markAsString = "failed";
        Console.WriteLine("Result: {0}", markAsString);
        
        markAsString = mark >= 60 ? "aprobado" : "suspenso";
        Console.WriteLine("Result: {0}", markAsString);
    }
}
