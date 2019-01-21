// Jorge Calzada Asenjo

using System;

class Car
{
    protected static int wheels = 4;

    public int GetWheels() { return wheels; }
}

// ------------------------------------

class CarTest
{
    static void Main()
    {
        Car car1 = new Car();
        Car car2 = new Car();

        Console.WriteLine(car1.GetWheels());
        Console.WriteLine(car2.GetWheels());
    }
}
