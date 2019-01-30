using System;

sealed class Vector2D
{
    private double x;
    private double y;

    public Vector2D( double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public void SetX(double x) { this.x = x; }
    public void SetY(double y) { this.y = y; }

    public double GetX() { return x; }
    public double GetY() { return y; }

    public override string ToString()
    {
        return "<" + x + ", " + y + ">";
    }

    public double GetLength()
    {
        return Math.Sqrt(x * x + y * y);
    }

    public void Add(Vector2D v2)
    {
        x += v2.x;
        y += v2.y;
    }
    
    public static Vector2D Add(Vector2D v1, Vector2D v2)
    {
        // Vector2D result = new Vector2D(v1.x, v1.y);
        // result.Add(v2);
        // return result;
        
        return new Vector2D(v1.x + v2.x, v1.y + v2.y);
    }
}

class TestVectors
{
    public static void Main()
    {
        Vector2D v = new Vector2D(20, 11);
        Console.WriteLine(v);
        v.Add( new Vector2D(13,24) );
        Console.WriteLine(v);
        Console.WriteLine(v.GetLength());
        
        
        Vector2D v1 = new Vector2D(-1, 3.5);
        Vector2D v2 = new Vector2D(11, 12);
        Vector2D v3 = Vector2D.Add(v1, v2);
        Console.WriteLine( v3 );
    }

}
