// Challenge 001 altered: Hola mundo + counter
using System;
public class HelloWorld
{
    public static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < number; i++)
            Console.WriteLine("{0} : Hola mundo.", i);
    }
}
