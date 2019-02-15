/**
 * EnemyFish.cs - Nodes Of Yesod, a specific type of enemy
 * 
 * Changes:
 * 0.12, 08-02-2019: First version of the class
 */

class EnemyFish : Enemy
{
    public EnemyFish()
    {
        LoadSequence(RIGHT,
            new string[] { "data/enemyFish1.png",
                "data/enemyFish2.png"});
        currentDirection = RIGHT;
    }

    public override void Move()
    {
        base.Move();
        NextFrame();
    }
}

