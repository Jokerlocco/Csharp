/*

Create a class "Point3D", to represent a point in 3-D space, 
with coordinates X, Y and Z. 

It must contain the following methods:

- Only one constructor, to set the values for X, Y and Z
- MoveTo(x,y,z), which will change the coordinates in which the point is.
- DistanceTo(Point3D p2), to calculate the distance to another point.
- ToString, which will return a string similar to "(2,-7,0)"
- And, of course, getters and setters.

The test program must create a pint, with coordinates chosen by the
user, and display the distance from it to (1, 0, -1).

*/

using System;

public class Point3D
{
    protected double x;
    protected double y;
    protected double z;

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

    public double GetX() { return x; }
    public double GetY() { return y; }
    public double GetZ() { return z; }

    public void SetX(double x) { this.x = x; }
    public void SetY(double y) { this.y = y; }
    public void SetZ(double z) { this.z = z; }

    public double DistanceTo( Point3D q )
    {
        return Math.Sqrt(
            (x - q.GetX()) * (x - q.GetX()) +
            (y - q.GetY()) * (y - q.GetY()) +
            (z - q.GetZ()) * (z - q.GetZ()));
    }

    public override string ToString()
    {
        return "("+x+","+y+","+z+")";
    }


}

public class Point3DTest
{
    public static void Main()
    {
        double x, y, z;
        Console.Write("Enter X: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Y: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Z: ");
        z = Convert.ToDouble(Console.ReadLine());
        
        Point3D p = new Point3D(x, y, z);
        
        Console.WriteLine("P = " + p.ToString() );
        Console.WriteLine("P = " + p );

        Console.WriteLine("Distance to (1,0,-1) = " +
            p.DistanceTo( new Point3D(1, 0, -1) ));
    }
}
