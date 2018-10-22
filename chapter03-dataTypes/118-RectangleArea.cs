using System;
//Miguel Isidro Blaco

public class RectangleArea
{
    public static void Main()
    {
        Console.Write("Enter the width: ");
        double width = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        
        double area = width*height;
        double perimeter = width + width + height + height;
        double diagonal = Math.Sqrt(width*width + height*height);
        
        Console.WriteLine("Area = " + area);
        Console.WriteLine("Perimeter = " + perimeter);
        Console.WriteLine("Diagonal = " + diagonal);
    }
}
