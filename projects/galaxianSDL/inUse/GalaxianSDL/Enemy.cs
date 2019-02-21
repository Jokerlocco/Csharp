// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 011, 21-Feb-19   Sergio, Diego: Constructor + Move
// 009, 21-Feb-19   Nacho: Empty skeleton


class Enemy : Sprite
{

    public Enemy(int x, int y)
    {
        this.x = x;
        this.y = y;
        width = 33;
        height = 24;
        xSpeed = 3;
        LoadImage("data/enemy1a.png");
    }

    public override void Move()
    {
        this.x += xSpeed;
        if (x <= 50 || x >= 950)
        {
            xSpeed = -xSpeed;
        }
    }
}
