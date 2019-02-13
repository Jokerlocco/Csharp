# sv2018-programming

## Nodes Of Yesod 004

### Enemy + player

We are goin to create classes for the enemy and the player:

```
class Enemy : Sprite
{
    public Enemy()
    {
        LoadImage("data/enemy.png");
        width = 64;
        height = 64;
    }
}

class Player : Sprite
{
    public Player()
    {
        LoadImage("data/player.png");
        x = 50;
        y = 120;
        xSpeed = ySpeed = 8;
        width = 32;
        height = 64;
    }

    public void MoveRight()
    {
        x += xSpeed;
    }

    public void MoveLeft()
    {
        x -= xSpeed;
    }

    public void MoveUp()
    {
        y -= ySpeed;
    }

    public void MoveDown()
    {
        y += ySpeed;
    }
}
```

And Game will use these classes, instead of structs or independent variables:


```
static Player player;
static Enemy[] enemies;

// ...

for (int i = 0; i < numEnemies; i++)
{
	enemies[i] = new Enemy();
}

// ...

player.DrawOnHiddenScreen();
for (int i = 0; i < numEnemies; i++)
	enemies[i].DrawOnHiddenScreen();

// ...

if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
	player.MoveRight();

// ...
```
