// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 009, 21-Feb-19   Nacho: Empty skeleton

class Player : Sprite
{
    protected Fire fire;

    public Player()
    {
        x = 0;
        y = 0;
        xSpeed = 10;
        LoadImage("data/ship.png");
        width = 45;
        height = 51;
        fire = new Fire(x, y);
    }

    public void MoveRight()
    {
        x += xSpeed;
    }

    public void MoveLeft()
    {
        x -= xSpeed;
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
