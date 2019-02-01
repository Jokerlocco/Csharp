// Ivan Lazcano

using System;

class ComplexNumber
{
    protected double real, img;

    public ComplexNumber(double real, double img)
    {
        this.real = real;
        this.img = img;
    }

    public void SetReal(double a) { this.real = a; }
    public void SetImg(double b) { this.img = b; }

    public double GetReal() { return real; }
    public double GetImg() { return img; }

    public override string ToString()
    {
        return "(" + real + ", " + img + ")";
    }

    public double GetMagnitude()
    {

        return Math.Sqrt(real * real + img * img);
    }
    
    public void Sum(ComplexNumber c2)
    {
        real += c2.real;
        img += c2.img;
    }
    
    public static ComplexNumber Sum(
        ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.real + c2.real, 
            c1.img + c2.img);
    }
    
    
    public static ComplexNumber operator + (
        ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.real + c2.real, 
            c1.img + c2.img);
    }
    
    public static ComplexNumber operator - (
        ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.real - c2.real, 
            c1.img - c2.img);
    }
}

//-----

class Test
{

    public static void Main()
    {
        ComplexNumber a = new ComplexNumber(22, 10);
        Console.WriteLine(a);
        ComplexNumber b = new ComplexNumber(-123, 44.22);
        a += b;
        Console.WriteLine(a);
        Console.WriteLine(a.GetMagnitude());
        Console.WriteLine(ComplexNumber.Sum(a,b));
    }

}
