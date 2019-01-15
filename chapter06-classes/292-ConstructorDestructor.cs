// Constructor & Destructor
// Javier Benajes

using System;

class ConstructorDestructor
{
    public ConstructorDestructor()
    {
        Console.WriteLine("Constructor");
    }

    ~ConstructorDestructor()
    {
        Console.WriteLine("Destructor");
    }

    public void Pause()
    {
        Console.WriteLine("Press Enter...");
        Console.ReadLine();
    }
}

class ConstructorDestructorTest
{
    public static void Main()
    {
        ConstructorDestructor cd = new ConstructorDestructor();
        cd.Pause();
    }
}
