/**
 * EnemyFire.cs - Nodes Of Yesod, a specific type of enemy
 * 
 * Changes:
 * 0.12, 08-02-2019: First version of the class
 */

class EnemyFire : Enemy
{
    public EnemyFire()
    {
        LoadSequence(RIGHT,
            new string[] { "data/enemyFire1.png",
                "data/enemyFire2.png",
                "data/enemyFire3.png"});
        currentDirection = RIGHT;
    }

    public override void Move()
    {
        base.Move();
        NextFrame();
    }
}

