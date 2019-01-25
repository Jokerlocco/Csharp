using System;

class Point3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
    
    public Point3D(double x, double y, double z)
    {
        MoveTo(x, y, z);
    }
    
    public void MoveTo(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    
    public double DistanceTo(Point3D p2)
    {
        return Math.Sqrt(Math.Pow(X - p2.X,2) +
            Math.Pow(Y - p2.Y,2) +
            Math.Pow(Z - p2.Z,2));
    }
    
    public override string ToString()
    {
        return "(" + X + "," + Y + "," + Z + ")";
    }
}

class Point3DTest
{
    static void Main()
    {
        double x, y, z;
        Console.Write("Enter X: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Y: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Z: ");
        z = Convert.ToDouble(Console.ReadLine());
        
        Point3D p = new Point3D(x, y, z);
        
        Console.WriteLine("P = " + p);
        Console.WriteLine(p.DistanceTo(new Point3D(1,0,-1)));
        
        p.Z += 5;
        Console.WriteLine("P(z incremented) = " + p);
    }
}
