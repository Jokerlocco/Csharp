// Javier Benajes

using System;

public class Greeting2
{
    public static void SayHello(string name)
    {
        Console.WriteLine("Hi, {0}", name);
    }
    
    public static void Main()
    {
        SayHello("Nacho");
        SayHello("Javi");
    }
}
