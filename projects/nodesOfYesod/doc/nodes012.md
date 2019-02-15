# sv2018-programming

## Nodes Of Yesod 012

### Different enemies

We can create different kinds of enemies, inheriting from the class Enemy.
They will only differ in their images:

```
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
```

And we might change the room descriptions to include them:

```
"                1",
"                1",
"                2",
"                1",
"  ABAB      e   2",
"                2",
"                2",
"            BB  1",
"       g        1",
"                1",
"      ABBAB     1"
```

And the way we analyse the room:

```
if (levelData[row][col] == 'e')
    Enemies[NumEnemies] = new EnemyFire();
else if (levelData[row][col] == 'g')
    Enemies[NumEnemies] = new EnemySpring();
else
    Enemies[NumEnemies] = new EnemyFish();
```

That should be (almost) all it takes.
