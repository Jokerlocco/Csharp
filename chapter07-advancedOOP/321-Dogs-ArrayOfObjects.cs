/*

Create a class "Dog" with a method "Bark", which will 
display "Woof" on screen.

Create in Main an array of 3 dogs and make them bark.

*/

using System;

public class Dog
{
    public void Bark()
    { 
        Console.Write("Woof");
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
            dogs[i] = new Dog();
        }
        for (int i = 0; i < SIZE; i++)
        {
            dogs[i].Bark();
        }
    }
}
