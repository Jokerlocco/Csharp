// Constructors & Destructors 2: Calling order
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

    public void Pausar()
    {
        Console.Write("Press Enter...");
        Console.ReadLine();
    }
}

class ConstructorDestructor2 : ConstructorDestructor
{
    public ConstructorDestructor2()
    {
        Console.WriteLine("Constructor2");
    }

    ~ConstructorDestructor2()
    {
        Console.WriteLine("Destructor2");
    }
}

class ConstructorDestructorTest
{
    public static void Main()
    {
        ConstructorDestructor2 cd2 = new ConstructorDestructor2();
    }
}
