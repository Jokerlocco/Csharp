// Area of a circle (float data type)

// Sample run:
// Enter radius: 3.5
// Its area is 38.4845

using System;

public class CircleFloat
{
    public static void Main()
    {
        float pi = 3.141592f;
    
        Console.Write("Enter radius: ");
        float radius = Convert.ToSingle(Console.ReadLine());

        float area = pi * (radius * radius);
        Console.WriteLine("Its area is {0}", area);
    }
}
