/*

Create a class called "Title."

Its (public) attributes will be the text and the x and y coordinates.

It must have a method called "Show", which will display the text on the 
screen, at the coordinates indicated by the attributes.

Create a class "TitleTest" with a "Main" to test it.

*/

using System;

// ---------------------------

class Title
{
    // Note: attributes should not be public
    // We'll improve it in later versions
    public int x;
    public int y;
    public string text;
    
    public void Show()
    {
        Console.SetCursorPosition(x,y);
        Console.Write(text);
    }
}

// ---------------------------

class TitleTest
{
    static void Main()
    {
        Title t = new Title();
        t.x = 40;
        t.y = 12;
        t.text = "Hello!";
        
        t.Show();
    }
}
