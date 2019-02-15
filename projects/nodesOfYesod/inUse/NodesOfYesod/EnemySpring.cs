/**
 * EnemySpring.cs - Nodes Of Yesod, a specific type of enemy
 * 
 * Changes:
 * 0.12, 08-02-2019: First version of the class
 */

class EnemySpring : Enemy
{
    public EnemySpring()
    {
        LoadSequence(RIGHT,
            new string[] { "data/enemySpring1.png",
                "data/enemySpring2.png"});
        currentDirection = RIGHT;
    }

    public override void Move()
    {
        base.Move();
        NextFrame();
    }
}

