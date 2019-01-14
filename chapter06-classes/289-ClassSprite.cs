// Adrián Navarro Gabino

using System;

class Sprite
{
    protected int x;
    protected int y;
    
    public void SetX(int posX) { x = posX; }
    public void SetY(int posY) { y = posY; }
    
    public int GetX() { return x; }
    public int GetY() { return y; }
    
    public Sprite(int newX, int newY)
    {
        x = newX;
        y = newY;
    }
    
    public Sprite()
    {
        x = 0;
        y = 0;
    }
    
    public void Draw()
    {
        // TO DO
    }
    
    public void MoveTo(int newX, int newY)
    {
        x = newX;
        y = newY;
    }
}


class SpriteTest
{
    static void Main()
    {
        Sprite mySprite = new Sprite();
        mySprite.MoveTo(100, 150);
        mySprite.SetY(160);
        Console.WriteLine(mySprite.GetX());
    }
}
