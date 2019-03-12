// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 023m,12-Mar-19   Nacho: Adapted to Monogame
// 016, 21-Feb-19   Calzada: skeleton, constructor and move


using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

class Fire : Sprite
{
    public Fire(int x, int y, ContentManager c)
    {
        MoveTo(x, y);
        ySpeed = 5;
        LoadImage("fire", c);
        width = 3;
        height = 12;
        visible = false;
    }

    public override void Move()
    {
        if (y > 21)
        {
            y -= ySpeed;
        }
        else
        {
            visible = false;
        }
    }
}
