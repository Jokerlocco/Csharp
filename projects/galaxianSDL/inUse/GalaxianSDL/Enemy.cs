// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 021, 26-Feb-19   Adrian: Explosion
// 011, 21-Feb-19   Sergio, Diego: Constructor + Move
// 009, 21-Feb-19   Nacho: Empty skeleton


class Enemy : Sprite
{
    protected bool dying;
    protected int dyingCount;

    public Enemy(int x, int y)
    {
        this.x = x;
        this.y = y;
        width = 33;
        height = 24;
        xSpeed = 3;
        currentDirection = RIGHT;
        LoadSequence(RIGHT,
            new string[] { "data/enemy1a.png",
                "data/enemy1b.png"});
        gameUpdatesPerFrame = 12;

        LoadSequence(DISAPPEARING,
            new string[] { "data/explosion1.png",
                "data/explosion2.png", "data/explosion3.png",
                "data/explosion4.png"});
        dying = false;
        dyingCount = 0;
    }

    public override void Move()
    {
        NextFrame();
        this.x += xSpeed;
        if (x <= 50 || x >= 950)
        {
            xSpeed = -xSpeed;
        }
        if (dying)
        {
            ChangeDirection(DISAPPEARING);
            dyingCount++;
            if (dyingCount > 4)
                visible = false;
        }
    }

    public void Die() { dying = true; }
    public void IncreaseDiying() { dyingCount++; }

    public bool IsDying() { return dying; }
    public int GetDiyingCount() { return dyingCount; }
}
