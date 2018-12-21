/*
Create a new version of the "Title" + "TitleUnderlined" project.
Now the attributes will be "protected".
*/

using System;

// ---------------------------

class Title
{
    protected int x;
    protected int y;
    protected string text;
    
    public void SetX(int newX) { x = newX; }
    public void SetY(int newY) { y = newY; }
    public void SetText(string newText) { text = newText; }

    public void Show()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(text);
    }
}

// ---------------------------

class TitleUnderlined : Title
{
    public void Show()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(text);

        int hyphens = text.Length;
        Console.SetCursorPosition(x, y+1);
        Console.Write( new string('-', hyphens) );
    }
}

// ---------------------------

class TitleTest
{
    static void Main()
    {
        Title t = new Title();
        t.SetX(40);
        t.SetY(12);
        t.SetText("Hello!");
        t.Show();

        TitleUnderlined t2 = new TitleUnderlined();
        t2.SetX(30);
        t2.SetY(15);
        t2.SetText("Bye!");
        t2.Show();
    }
}
