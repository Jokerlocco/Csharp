/**
 * Enemy.cs - Nodes Of Yesod, a simple enemy
 * 
 * Changes:
 * 0.06, 23-01-2019: Simple side-to-side movement
 * 0.04, 16-01-2019: Class created (only constructor)
 */

class Enemy : Sprite
{
    public Enemy()
    {
        LoadImage("data/enemy.png");
        width = 64;
        height = 64;
        xSpeed = 6;
    }

    public override void Move()
    {
        x += xSpeed;
        if ((x < 50) || (x > 970))
            xSpeed = -xSpeed;

    }
}

