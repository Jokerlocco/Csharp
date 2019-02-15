# sv2018-programming

## Nodes Of Yesod 008

### Gravity, jump, enemies in the level

Gravity is easy: we only need the player to "try to fall" in every frame of the 
game:

```
public void Move()
{
    // ...
    if (room.CanMoveTo(
        x, 
        y + ySpeed,
        x + width, 
        y + ySpeed + height))
    {
        y += ySpeed;
        falling = true;
    }
    else
        falling = false;
}
```

In most games, when the player is falling (or, later, jumping), they will
not be allowed to move right or left, so we will need a couple of booleans:

```
protected bool jumping = false, falling = false;
```

And for the jump, it should have a parabolic trajectory, but instead of
using the parabola equation "y = ax2 + bx + c", and finding the correct values
for a,b,c each time the user wants to jump, it might be simpler to precalculate
how much is the "y" going to change for each step during the jump, and store
it in an array, like this:

```
int[] stepsOfJump = {-46, -38, -31, -25, -18, -12, -7, -3, -1, 0,
                           0, 1, 3, 7, 12, 18, 25, 31, 38, 46 };
protected int frameOfTheJump = 0;
```

(those number can be fine-tuned for each game, depending on how wide and
how tall we want our player to jump).

Then, depending on if the user wants to jump upwards, to the right or to
the left, we might have 3 different methods to start the jump sequence:

```
// Starts the vertical jump sequence
public void Jump(Room room)
{
    if (jumping || falling)
        return;
    jumping = true;
    xJumpSpeed = 0;
}

// Starts the jump right sequence
public void JumpRight(Room room)
{
    Jump(room);
    xJumpSpeed = xSpeed;
}


// Starts the jump left sequence
public void JumpLeft(Room room)
{
    Jump(room);
    xJumpSpeed = -xSpeed;
}
```

And then, the "Move" method would increment or decrement the "y" coordinate
when we are still in the middle of a jump sequence:

```
public void Move(Room room)
{
    if (jumping)
    {
        // First, let's calculate next position and
        // check if it is valid
        short xNextMove = (short)(x + xJumpSpeed);
        short yNextMove = (short)(y + stepsOfJump[frameOfTheJump]);
        //bool jumpingUpwards = (stepsOfJump[frameOfTheJump] < 0);

        // If we can still move, let's do it
        if (room.CanMoveTo(
                xNextMove, 
                yNextMove,
                xNextMove + width, 
                yNextMove + height)
            //|| jumpingUpwards
            )
        {
            x = xNextMove;
            y = yNextMove;
            NextFrame();
        }
        // Otherwise, we might be falling
        else
        {
            jumping = false;
            falling = true;
        }

        frameOfTheJump++;
        if (frameOfTheJump >= stepsOfJump.Length)
        {
            jumping = false;
            falling = true;
            frameOfTheJump = 0;
        }
    }
    else // try to fall (gravity)
    {
        if (room.CanMoveTo(
            x, 
            y + ySpeed,
            x + width, 
            y + ySpeed + height))
        {
            y += ySpeed;
            falling = true;
        }
        else
            falling = false;
    }
}
```

In the class Game, we should check which keys are pressed, in order to 
know if the user wants a vertical jump, a jump to the right or a jump
to the left:

```
void CheckUserInput()
{
    if (SdlHardware.KeyPressed(SdlHardware.KEY_SPC))
    {
        if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
            player.JumpRight(room);
        else if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT))
            player.JumpLeft(room);
        else
            player.Jump(room);
    }


    if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
    {
            player.MoveRight(room);
    }
    if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT))
    {
            player.MoveLeft(room);
    }

    if (SdlHardware.KeyPressed(SdlHardware.KEY_ESC))
        finished = true;
}
```

And finally, telling where the enemies are as part of the Room would
not mean many changes in the Game:

```
void UpdateWorld()
{
    // Move player: gravity or jump
    player.Move(room);
    // Move enemies, background, etc 
    for (int i = 0; i < room.NumEnemies; i++)
        room.Enemies[i].Move();
}
```

And it would be a little change in the Room:

```
class Room
{
    // ...

    protected string[] levelData =
    {
        "1                ",
        "2                ",
        "1                ",
        "1                ",
        "2           e    ",
        "2                ",
        "1[]              ",
        "2||         []   ",
        "1||    e    ||   ",
        "1||         ||   ",
        "AABAAAABBABAAABAA"};

    public Room()
    {
        // Let's load the images
        wallL1 = new Image("data/tile-wallL1.png");
        wallL2 = new Image("data/tile-wallL2.png");
        floor1 = new Image("data/tile-floor1.png");
        floor2 = new Image("data/tile-floor2.png");
        platform1 = new Image("data/tile-platf1.png");
        platform2 = new Image("data/tile-platf2.png");
        column = new Image("data/tile-column1.png");

        // And let's extract the info about the enemies from the map
        Enemies = new Enemy[MAX_ENEMIES];
        for (int row = 0; row < mapHeight; row++)
        {
            for (int col = 0; col < mapWidth; col++)
            {
                if (levelData[row][col] == 'e')
                {
                    int posX = col * tileWidth + leftMargin;
                    int posY = row * tileHeight + topMargin;
                    Enemies[NumEnemies] = new Enemy();
                    Enemies[NumEnemies].MoveTo(posX, posY);
                    Enemies[NumEnemies].SetSpeed(2, 2);
                    NumEnemies++;
                    levelData[row] = levelData[row].
                        Remove(col, 1).Insert(col," ");
                }
            }
        }
    }

    // ...
```
