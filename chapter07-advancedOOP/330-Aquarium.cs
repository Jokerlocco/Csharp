// Adrián Navarro Gabino

using System;

class Aquarium
{
    public int Capacity { get; set; }
    public int Size { get; set; }

    public void ChangeWater()
    {
        // TODO
    }

    public void ReleaseFood()
    {
        // TODO
    }
}

// -------------------------------------------------------------------

class AquariumElement
{
    public string Image { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    
    public void Display()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write(Image);
    }
    
    public virtual void Animate()
    {
    }
}

// -------------------------------------------------------------------

class LivingBeing : AquariumElement
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }
}

// -------------------------------------------------------------------

class Inanimate : AquariumElement
{
    public int Position { get; set; }
}

// -------------------------------------------------------------------

class Rock : Inanimate
{
}

// -------------------------------------------------------------------

class Fish : LivingBeing
{
    public bool HasStripes { get; set; }

    public void Swim()
    {
        // TODO
    }

    public void Eat()
    {
        // TODO
    }

    public void Breath()
    {
        // TODO
    }

    public void FormBank()
    {
        // TODO
    }
}

// -------------------------------------------------------------------

class ClownFish : Fish
{
}

// -------------------------------------------------------------------

class Shark : Fish
{
}

// -------------------------------------------------------------------

class Trout : Fish
{
}

// -------------------------------------------------------------------

class Coral : LivingBeing
{
    public void ThrowBubbles()
    {
        // TODO
    }
}

// -------------------------------------------------------------------

class AquariumTest
{
    static void Main()
    {
        Aquarium aq = new Aquarium();
    }
}
