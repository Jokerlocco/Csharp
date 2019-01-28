// Ivan Lazcano

using System;

abstract class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public float Power { get; set; }
    public int Speed { get; set; }

    public Vehicle(string newBrand, string newModel, double newPower)
    {
        Brand = newBrand;
        Model = newModel;
        Power = (float)newPower;
        Speed = 0;
    }

    public void Start()
    {
        // TO DO
    }

    public void Accelerate()
    {
        if (Speed <= 205)
            Speed += 5;
    }

    public void Brake()
    {
        if (Speed >= 5)
            Speed -= 5;
    }

    override public string ToString()
    {
        return Brand + " " + Model +
            ", " + Power + " HP, " +
            Speed + " km/h";
    }
}

// ----------------------------------

class Car : Vehicle
{
    private byte doors;

    public Car(string Brand, string Model, double Power, byte doors) 
    : base( Brand, Model, Power)
    {
        this.doors = doors;
        Speed = 0;
    }

    override public string ToString()
    {
        return base.ToString() + ". " + doors + " doors.";
    }
       
}
// ----------------------------------

class Motorbike : Vehicle
{
    public string License { get; set; }

    public Motorbike(string Brand, string Model,
            double Power, string License)  
    : base(Brand, Model, Power)
    {

        this.License = License;
        Speed = 0;
    }
}

// ----------------------------------

class CarTest
{
    static void Main(string[] args)
    {
        const int CANTVEHICULOS = 1000;
        int countVehicles = 0;
        string option;
        Vehicle[] v = new Vehicle[CANTVEHICULOS];

        do
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Print data");
            Console.WriteLine("3. Search");
            Console.WriteLine("Q. Quit");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("1. MotorBike");
                    Console.WriteLine("2. Car");
                    option = Console.ReadLine();
                    Console.WriteLine("Brand? ");
                    string brand = Console.ReadLine();
                    Console.WriteLine("Model? ");
                    string model = Console.ReadLine();
                    Console.WriteLine("Power? ");
                    double power = Convert.ToDouble(Console.ReadLine());
                    if (option == "1")
                    {

                        Console.WriteLine("License? ");
                        string license = Console.ReadLine();
                        v[countVehicles] = new Motorbike(brand, 
                            model, power, license);
                    }
                    else
                    {
                        Console.WriteLine("Number of Doors? ");
                        byte doors = Convert.ToByte(Console.ReadLine());
                        v[countVehicles] = new Car(brand, 
                            model, power, doors);
                    }
                    countVehicles++;
                    Console.WriteLine("Added!");
                    break;

                case "2":
                    for (int i = 0; i < countVehicles; i++)
                    {
                        Console.WriteLine((i+1) + ": " + v[i]);
                    }
                    break;

                case "3":
                    Console.WriteLine("Search term?");
                    string search = Console.ReadLine();
                    int amount = 0;
                    for (int i = 0; i < countVehicles; i++)
                    {
                        if (v[i].ToString().Contains(search))
                        {
                            Console.WriteLine((i + 1) + ": " + v[i]);
                            amount ++;
                        }
                    }
                    if (amount == 0)
                        Console.WriteLine("Not found!");

                    break;

            }
        } while (option.ToUpper() != "Q");
    }
}
