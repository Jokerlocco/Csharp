using System;

class ComplexNumber
{
    protected double a;
    protected double b;

    public ComplexNumber(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public void SetReal(double a) { this.a = a; }
    public void SetImag(double b) { this.b = b; }

    public double GetReal() { return a; }
    public double GetImag() { return b; }

    public override string ToString()
    {
        return "(" + a + ", " + b + ")";
    }

    public double GetMagnitude()
    {
        return Math.Sqrt(a * a + b * b);
    }

    public void Add(ComplexNumber c2)
    {
        a += c2.a;
        b += c2.b;
    }
}

class TestComplexNumber
{
    public static void Main()
    {
        ComplexNumber c = new ComplexNumber(2, -3);
        Console.WriteLine(c);
        c.Add(new ComplexNumber(2, -3));
        Console.WriteLine(c);
        Console.WriteLine(c.GetMagnitude());
    }

}
