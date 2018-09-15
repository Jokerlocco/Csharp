//  Daniel Contreras 

using System;

public class Piropo
{
    public static void Main()
    {
        int age;
        
        Console.Write("What is your age? ");
        age = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("It looks like you are ");
        Console.Write(age-1);
        Console.WriteLine(" or even younger...");
    }
}
