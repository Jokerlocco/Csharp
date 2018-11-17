// Javier Benajes

using System;

public class SquareNewString
{
    public static void Main()
    {
        Console.Write("Size of the square? ");
        int size = Convert.ToInt32(Console.ReadLine());
        string line = new string('*', size);
        
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(line);
        }
    }
}
