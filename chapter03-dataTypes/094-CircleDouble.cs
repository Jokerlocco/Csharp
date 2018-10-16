// Area of a circle (double data type)
// Daniel Contreras

// Sample run:
// Enter radius: 3.5
// Its area is 38.484510005375

using System;

public class CircleDouble
{
    public static void Main()
    {
        double pi = 3.1415926535;
        
        Console.Write("Enter radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        
        double area = pi*(radius * radius);
        Console.WriteLine("Its area is {0}", area);
    }
}
