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

