// Indirect recursion -> stack overflow

using System;

class House
{
    protected Person p;

    public House()
    {
        Console.Write("Creating a house... ");
        p = new Person();
    }
}

class Person
{
    protected House house;
    
    public Person()
    {
        Console.Write("Creating a person... ");
        house = new House();
    }
}

class Test
{
    static void Main()
    {
        Person p1 = new Person();
    }
}
