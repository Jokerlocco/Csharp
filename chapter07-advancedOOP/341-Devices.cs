/*
We want to create a program to keep track of a series of programmable 
electronic devices.

In a first simplistic approach, we will distinguish between "tactile 
devices" and "devices with keyboard". For the first category, we will 
divide them into "smartphones" and "tablets", and for the latter, only 
as "computers."

We will want to store the processing speed and screen size (diagonal, 
in inches) for each of them. You will have to create the appropriate 
getters and setters, along with a constructor that allows setting the 
starting values. You must also create a "ToString" method, which will 
return a text such as "Smartphone, 800 MHz, 3.2 inches".

In addition, you must create a program that allows the user to enter 
data of devices in any of the three types (in a single array) and to 
see all the data that have been entered.
*/

// Ivan

using System;

abstract class Device
{
    public int CpuSpeed { get; set; }
    public double ScreenSize { get; set; }

    public Device( int CpuSpeed, double ScreenSize)
    {
        this.CpuSpeed = CpuSpeed;
        this.ScreenSize = ScreenSize;
    }

    override public string ToString()
    {
        return "CPU speed: " + CpuSpeed + 
            "MHz, Screen size: " + ScreenSize + " Inches";
    }

}

abstract class Tactile : Device
{
    public Tactile(int CpuSpeed, double ScreenSize) 
        : base( CpuSpeed, ScreenSize)
    {
    }
}

class Smartphone : Tactile
{
    public Smartphone(int CpuSpeed, double ScreenSize) 
        : base( CpuSpeed, ScreenSize)
    {
    }
    
    override public string ToString()
    {
        return "Smartphone, " + base.ToString();
    }
}


class Tablet : Tactile
{
    public Tablet(int CpuSpeed, double ScreenSize) 
        : base( CpuSpeed, ScreenSize)
    {
    }
    
    override public string ToString()
    {
        return "Tablet, " + base.ToString();
    }
}

abstract class WithKeyboard : Device
{
    public WithKeyboard(int CpuSpeed, double ScreenSize) 
        : base( CpuSpeed, ScreenSize)
    {

    }
}


class Computer : WithKeyboard
{
    public Computer(int CpuSpeed, double ScreenSize) 
        : base( CpuSpeed, ScreenSize)
    {
    }
    
    override public string ToString()
    {
        return "Computer, " + base.ToString();
    }
}


class Test
{
    public static void Main()
    {
        const int NUMDEVICES = 10;
        Device[] d = new Device[NUMDEVICES];
        d[0] = new Smartphone(4000, 7);
        d[1] = new Computer(12000, 24);
        d[2] = new Tablet(9999, 13);
        foreach(Device x in d)
            Console.WriteLine(x);

        // TO DO: Ask the user and show data
    }

}
