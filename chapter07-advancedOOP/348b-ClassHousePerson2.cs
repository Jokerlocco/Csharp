// Avoiding indirect recursion -> no stack overflow

// Jorge Calzada Asenjo

using System;

class House
{
    protected Person p;
    
    public House()
    {
        Console.Write("Creating a house... ");
    }

    public void SetPerson(Person person) { this.p = person; }
}

class Person
{
    protected House house;

    public Person()
    {
        Console.Write("Creating a person... ");
        house = new House();
        house.SetPerson(this);
    }
}

class Test
{
    static void Main()
    {
        Person p1 = new Person();
    }
}
