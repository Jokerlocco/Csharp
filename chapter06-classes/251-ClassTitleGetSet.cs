/*
Create a new version of the class "Title".

Its attributes will be private and it will include getters and setters.

Change the program and "Main" as necessary.
*/

using System;

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

class TitleTest
{
    static void Main()
    {
        Title t = new Title();
        t.SetX(40);
        t.SetY(12);
        t.SetText("Hello!");

        t.Show();
    }
}
