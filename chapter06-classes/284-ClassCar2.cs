// Class Car

using System;

class Car
{
    private string brand;
    private string model;
    private float power;
    private byte doors;
    private int speed;

    public Car(string newBrand, string newModel,
        double newPower, byte newDoors)
    {
        brand = newBrand;
        model = newModel;
        power = (float) newPower;
        doors = newDoors;
        speed = 0;
    }
    

    public void SetBrand(string newBrand)
    {
        brand = newBrand;
    }

    public void SetPower(double newPower)
    {
        power = (float) newPower;
    }

    public string GetBrand()
    {
        return brand;
    }

    public double GetPower()
    {
        return power;
    }

    public void Start()
    {
        // TO DO
    }

    public void Accelerate()
    {
        if (speed <= 205)
            speed += 5;
    }

    public void Brake()
    {
        if (speed >= 5)
            speed -= 5;
    }

    public void DisplayStatus()
    {
        Console.WriteLine(brand + " " + model +
            ", " + power + " HP, " + doors + " doors. "+
            speed + " km/h");
    }
}

// ----------------------------------

class CarTest
{
    static void Main(string[] args)
    {
        Car c = new Car("Peugeot", "507", 140, 5);
        c.SetPower(137.7);
        Console.WriteLine("Power: " + c.GetPower());

        c.Start();
        c.Accelerate();
        c.Accelerate();
        c.DisplayStatus();
    }
}
