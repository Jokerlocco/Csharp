// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 016, 21-Feb-19   Calzada: skeleton, constructor and move

class Fire : Sprite
{
    public Fire(int x, int y)
    {
        MoveTo(x, y);
        ySpeed = 5;
        LoadImage("data/fire.png");
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
