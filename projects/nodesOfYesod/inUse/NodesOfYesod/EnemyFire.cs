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

