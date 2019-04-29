// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 026, 17-Abr-19   Nacho: Attack, first approach
// 025, 17-Abr-19   Nacho: Screen size adjusted in Move (still magic numbers)
// 023, 12-Mar-19   Nacho: Speed is static
// 021, 26-Feb-19   Adrian: Explosion
// 011, 21-Feb-19   Sergio, Diego: Constructor + Move
// 009, 21-Feb-19   Nacho: Empty skeleton


class Enemy : Sprite
{
    protected bool dying;
    protected bool attacking;
    protected int dyingCount;
    protected static int blockSpeed;
    protected static System.Random randomGenerator = 
        new System.Random();

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
        attacking = false;

        blockSpeed = xSpeed;
    }

    public override void Move()
    {
        NextFrame();
        if (!attacking)
        {
            // It not attacking: move in the group
            this.x += blockSpeed;
            if (x <= 100 || x >= 730)  // TODO: Avoid magic numbers
            {
                blockSpeed = -blockSpeed;
            }
            // And maybe attack in next frame
            if (randomGenerator.NextDouble() > 0.9995)
                attacking = true;
        }
        else
        {
            // If attacking: individual movement
            // So far: just "fall"
            y+=2;

            // And return
            if (y > 720)
                y = 0;
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
