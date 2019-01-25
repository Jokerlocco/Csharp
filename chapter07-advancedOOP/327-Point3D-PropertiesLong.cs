// Adrián Navarro Gabino

using System;

class Point3D
{
    protected double x;
    protected double y;
    protected double z;
    
    public double X 
    {
        get
        {
            return x;
        }
        set
        {
            x = value;
        }
    }
    
    public double Y
    {
        get
        {
            return y;
        }
        set
        {
            y = value;
        }
    }
    
    public double Z
    {
        get
        {
            return z;
        }
        set
        {
            z = value;
        }
    }
    
    public Point3D(double x, double y, double z)
    {
        MoveTo(x, y, z);
    }
    
    public void MoveTo(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public double DistanceTo(Point3D p2)
    {
        return Math.Sqrt(Math.Pow(this.x - p2.X,2) +
            Math.Pow(this.y - p2.Y,2) +
            Math.Pow(this.z - p2.Z,2));
    }
    
    public override string ToString()
    {
        return "(" + this.x + "," + this.y + "," + this.z + ")";
    }
}

class DogTest
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
