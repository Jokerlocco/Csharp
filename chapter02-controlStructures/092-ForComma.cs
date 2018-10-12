using System;

public class ForComma
{
    public static void Main()
    {
        for (int i = 1, j=20; i <= 10 && j <= 30; i++, j=j+2)
        {
            Console.WriteLine("i={0}, j={1}", i, j);
        }
    }
}
