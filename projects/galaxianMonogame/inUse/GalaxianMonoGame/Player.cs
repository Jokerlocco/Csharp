// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 023m,12-Mar-19   Nacho: Adapted to Monogame
// 009, 21-Feb-19   Nacho: Empty skeleton


using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

class Player : Sprite
{
    protected Fire fire;

    public Player(ContentManager c)
    {
        x = 0;
        y = 0;
        xSpeed = 10;
        LoadImage("ship", c);
        width = 45;
        height = 51;
        fire = new Fire(x, y, c);
    }

    public void MoveRight()
    {
        x += xSpeed;
    }

    public void MoveRight(float gameTime)
    {
        x += (int) (xSpeed* 50 * gameTime);
    }

    public void MoveLeft()
    {
        x -= xSpeed;
    }

    public void MoveLeft(float gameTime)
    {
        x -= (int)(xSpeed * 50 * gameTime);
    }

    public Fire GetFire()
    {
        return fire;
    }

    public void Shoot()
    {
        if (!fire.IsVisible())
        {
            fire.MoveTo(x + 21, y + 1);
            fire.Show();
        }
    }
}
