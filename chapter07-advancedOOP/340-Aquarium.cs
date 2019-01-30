// Ivan Lazcano, Daniel Contreras

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
    
    public virtual void Display()
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
    public int Speed { get; set; }
}

// -------------------------------------------------------------------

class Inanimate : AquariumElement
{
    public int Position { get; set; }
}

// -------------------------------------------------------------------

class Rock : Inanimate
{
    public Rock()
    {
        Image = "M..^.";
    }
}

// -------------------------------------------------------------------

class Fish : LivingBeing
{
    public bool HasStripes { get; set; }

    public void Swim()
    {
        X += Speed;
        if (X >= 75 || X <= 5)
            Speed = -Speed;

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
    public ClownFish()
    {
        Speed = 2;
        Image = "><X>";
    }
}

// -------------------------------------------------------------------

class Shark : Fish
{
    public Shark()
    {
        Speed = 3;
        Image = "><";
    }
}

// -------------------------------------------------------------------

class Trout : Fish
{
    public Trout()
    {
        Speed = 1;
        Image = ">====<>";
    }
}

// -------------------------------------------------------------------

class Coral : LivingBeing
{
    public Coral()
    {
        Image = " | . |/. | .\\|./.|";
    }
    
    public override void Display()
    {
        string[] parts = Image.Split('.');
        for (int i = 0; i < parts.Length; i++)
        {
            Console.SetCursorPosition(X, Y+i);
            Console.Write(parts[i]);
        }
    }
    
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
        Console.SetWindowSize(80,25);
        Console.SetBufferSize(80,25);
        Aquarium aq = new Aquarium();

        ClownFish c = new ClownFish();
        c.X = 15; c.Y = 16;

        Trout t = new Trout();
        t.X = 5; t.Y = 6; 

        Shark s = new Shark();
        s.X = 60; s.Y = 22;

        Rock r1 = new Rock();
        r1.X = 10; r1.Y=24;
        
        Rock r2 = new Rock();
        r2.X = 40; r2.Y=24;
        
        Coral co = new Coral();
        co.X = 18; co.Y=19;

        do
        {
            System.Console.Clear();
            c.Swim();
            t.Swim();
            s.Swim();
            c.Display();
            t.Display();
            s.Display();
            co.Display();
            r1.Display();
            r2.Display();
            System.Threading.Thread.Sleep(200);
        } while (true);


    }
}
