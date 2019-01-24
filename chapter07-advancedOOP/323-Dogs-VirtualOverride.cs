/*

Use "virtual" and "override" instead of "new" 
and test the behavior of your array of dogs

*/

using System;

public class Dog
{
    public virtual void Bark()
    { 
        Console.Write("Woof");
    }
}

public class Dalmatian : Dog
{
    public override void Bark()
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
