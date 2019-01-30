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
    
    public static Vector2D operator + (Vector2D v1, Vector2D v2)
    {
        return new Vector2D(v1.x + v2.x, v1.y + v2.y);
    }
}

class TestVectors
{
    public static void Main()
    {
        Vector2D v1 = new Vector2D(-1, 3.5);
        Vector2D v2 = new Vector2D(11, 12);
        Vector2D v3 = v1 + v2;
        Console.WriteLine( v3 );
        
        v3 += v2;
        Console.WriteLine( v3 );
    }

}
