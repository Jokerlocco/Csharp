# sv2018-programming

## Galaxian SDL 002

Making an enemy rebound on the horizontal edge is easy. We just need to change
the sign of its speed:

```
if ((xEnemy <= 50) || (xEnemy >= 950))
    enemySpeed = -enemySpeed;
xEnemy += enemySpeed;
```

Moving our ship right and left is even easier:

```
if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
    xShip += 10;
if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT))
    xShip -= 10;
```

And if we want two enemies instead of one, with the few data structures
we know so far, we need to have duplicated code:

```
int xEnemy = 400;
int xEnemy2 = 200;
int enemySpeed = 5;
int enemySpeed2 = -3;
Image enemy1 = new Image("data/enemy1a.png");
Image enemy2 = new Image("data/enemy2a.png");

// ...

SdlHardware.DrawHiddenImage(enemy1, xEnemy, 200);
SdlHardware.DrawHiddenImage(enemy2, xEnemy2, 250);

// ...

if ((xEnemy <= 50) || (xEnemy >= 950))
    enemySpeed = -enemySpeed;
xEnemy += enemySpeed;

if ((xEnemy2 <= 50) || (xEnemy2 >= 950))
    enemySpeed2 = -enemySpeed2;
xEnemy2 += enemySpeed2;
```

