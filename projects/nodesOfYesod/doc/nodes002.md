# sv2018-programming

## Nodes Of Yesod 002

### Functions

We can split the program in functions, so that the game loop look like this:

```
 do
{
    UpdateScreen();
    CheckUserInput();
    UpdateWorld();
    PauseUntilNextFrame();
    CheckGameStatus();
}
while (!finished);
```

To achieve this, we will extract fragments of Main to create static functions 
such as this one:


```
static void CheckUserInput()
{
    if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
        playerX += playerSpeed;
    if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT))
        playerX -= playerSpeed;
    if (SdlHardware.KeyPressed(SdlHardware.KEY_UP))
        playerY -= playerSpeed;
    if (SdlHardware.KeyPressed(SdlHardware.KEY_DOWN))
        playerY += playerSpeed;

    if (SdlHardware.KeyPressed(SdlHardware.KEY_ESC))
        finished = true;
}
```

Also, we'll have to extract from Main the variables which we are going to share
between different functions, and make them static too:

```
static bool fullScreen;

static Image player;
static int playerX, playerY, playerSpeed;
static int playerWidth, playerHeight;

static int numEnemies;
static Image enemy;
static int enemyWidth;
static int enemyHeight;
static typeEnemy[] enemies;

static bool finished;
```

