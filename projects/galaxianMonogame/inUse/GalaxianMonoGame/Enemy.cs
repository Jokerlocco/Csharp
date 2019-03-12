// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 023m,12-Mar-19   Nacho: Speed is static + Adapted to Monogame
// 021, 26-Feb-19   Adrian: Explosion
// 011, 21-Feb-19   Sergio, Diego: Constructor + Move
// 009, 21-Feb-19   Nacho: Empty skeleton


using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

class Enemy : Sprite
{
    protected bool dying;
    protected int dyingCount;
    protected static int blockSpeed;

    public Enemy(int x, int y, ContentManager c)
    {
        this.x = x;
        this.y = y;
        width = 33;
        height = 24;
        xSpeed = 3;
        currentDirection = RIGHT;
        LoadSequence(RIGHT,
            new string[] { "enemy1a",
                "enemy1b"}, c);
        gameUpdatesPerFrame = 12;

        LoadSequence(DISAPPEARING,
            new string[] { "explosion1",
                "explosion2", "explosion3",
                "explosion4"}, c);
        dying = false;
        dyingCount = 0;

        blockSpeed = xSpeed;
    }

    public override void Move()
    {
        NextFrame();
        this.x += blockSpeed;
        if (x <= 50 || x >= 950)
        {
            blockSpeed = -blockSpeed;
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
