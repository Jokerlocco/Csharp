using System;

public class PruebaFuncion3
{
    public static void SayHelloManyTimes(string name, int times)
    {
        for ( int i = 0 ; i < times ; i++ )
        {
            Console.WriteLine("i, " + name);
        }
    }
    public static void Main()
    {
        Console.WriteLine("Who are we greeting to?");
        string who = Console.ReadLine();
        
        Console.WriteLine("How many times?");
        int n = Convert.ToInt32(Console.ReadLine());
        
        SayHelloManyTimes(who, n);
    }
}
