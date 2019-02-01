using System;

class House
{
    protected Person p;

    public House()
    {
        p = new Person();
    }
}

class Person
{
    protected House house;
    
    public Person()
    {
        house = new House();
    }
}

class Test
{
    static void Main()
    {
        House h = new House();
    }
}
