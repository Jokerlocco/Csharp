//Ivan Lazcano Sindin
using System;

class Car
{
    protected static byte wheels = 4;

    public byte GetWheels() { return wheels; }
    public void SetWheels(byte w) { wheels = w; }
}

//--------------------

class Test
{
    public static void Main()
    {
        Car c1 = new Car();
        Car c2 = new Car();
        Console.WriteLine("Car1: " + c1.GetWheels());
        Console.WriteLine("Car2: " + c2.GetWheels());
        c1.SetWheels(5);
        Console.WriteLine("Car1: " + c1.GetWheels());
        Console.WriteLine("Car2: " + c2.GetWheels());
    }

}
