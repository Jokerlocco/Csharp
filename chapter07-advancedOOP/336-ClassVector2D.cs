// Ivan Lazcano

using System;

class Vector2D
{
    protected double x;
    protected double y;

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
    }

}
