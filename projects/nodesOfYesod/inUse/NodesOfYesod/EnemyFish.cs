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

