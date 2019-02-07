/* Create an interface "Drawable", with a method Draw, and an interface 
"Measurable", with a method GetSize. Create a class ScreenRectangle, 
with atributes x1, y1 (upper left corner), x2, y2 (lower right corner)  
to implement both interfaces. */

using System;

// --------------------------------------------------

interface IDrawable
{
    int X;
    void Draw();
}

// --------------------------------------------------

interface IMeasurable
{
    int GetSize();
}

// --------------------------------------------------

class ScreenRectangle : IDrawable, IMeasurable
{
    protected int x1, y1, x2, y2;
    public ScreenRectangle(int x1, int y1, int x2, int y2)
    {
        this.x1 = x1;
        this.x2 = x2;
        this.y1 = y1;
        this.y2 = y2;
    }

    public void Draw()
    {
        for (int row = y1; row <= y2; row++)
        {
            for (int col = x1; col <= x2; col++)
            {
                Console.SetCursorPosition(col, row);
                Console.Write("X");
            }
        }
    }

    public int GetSize()
    {
        return (x2 - x1 + 1) * (y2 - y1 + 1);
    }
}

// --------------------------------------------------

public class RectangleTest
{
    public static void Main()
    {
        ScreenRectangle r1 = new ScreenRectangle(1,1, 4,2);
        r1.Draw();
        Console.SetCursorPosition(1, 3);
        Console.WriteLine( "Size = " + r1.GetSize() );
        
        
        ScreenRectangle r2 = new ScreenRectangle(10,4, 20,8);
        r2.Draw();
        Console.SetCursorPosition(1, 9);
        Console.WriteLine( "Size = " + r2.GetSize() );
    }
}
