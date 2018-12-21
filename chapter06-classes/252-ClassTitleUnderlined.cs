/*
Create a "TitleUnderlined" class, which inherits from "Title" and which will 
show hyphens below the title.

Your source file will contain now three classes: Title, TitleUnderlined and 
TitleTest.

Test it in "Main". You might get compilation errors ...

using System;
*/

// ---------------------------

class Title
{
    private int x;
    private int y;
    private string text;
    
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
        // Note: you will see compilation errors in the
        // next lines: x, y, text are not accesible (yet),
        // despite being a derived class
        Console.SetCursorPosition(x, y);
        Console.Write(text);
        Console.SetCursorPosition(x, y+1);
        Console.Write("-----");
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
