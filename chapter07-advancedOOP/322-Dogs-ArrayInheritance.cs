/*

Create a class "Dog" with a method "Bark", which will display "Woof" 
on screen.

Create a class "Dalmatian", inheriting from "Dog". Its "Bark" will 
display "Awww" on screen.

*/

using System;

public class Dog
{
    public void Bark()
    { 
        Console.Write("Woof");
    }
}

public class Dalmatian : Dog
{
    public new void Bark()
    { 
        Console.Write("Awww");
    }
}

public class DogTest
{
    public static void Main()
    {
        const int SIZE = 3;
        Dog[] dogs = new Dog[SIZE];
        for (int i = 0; i < SIZE; i++)
        {
            if (i==1)
                dogs[i] = new Dalmatian();
            else
                dogs[i] = new Dog();
        }
        for (int i = 0; i < SIZE; i++)
        {
            dogs[i].Bark();
        }
    }
}
