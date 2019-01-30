/**
 * Player.cs - Nodes Of Yesod, player-controlled sprite
 * 
 * Changes:
 * 0.08, 26-01-2019: 
 *   Player falls (gravity)
 *   Player can jump
 *   Player collision checking moved from class Game to class Player
 * 0.07, 25-01-2019: 
 *    Correct width and height, to check collisions properly
 *    Sequence of movement to the right and left
 * 0.04, 16-01-2019: Class created (constructor + move 4 directions)
 */

class Player : Sprite
{
    protected bool jumping = false, falling = false;
    protected int xJumpSpeed = 0;
    int[] stepsOfJump = {-46, -38, -31, -25, -18, -12, -7, -3, -1, 0,
                               0, 1, 3, 7, 12, 18, 25, 31, 38, 46 };
    protected int frameOfTheJump = 0;

    public Player()
    {
        //LoadImage("data/player.png");
        LoadSequence(RIGHT,
            new string[] { "data/playerR1.png",
                "data/playerR2.png"});
        LoadSequence(LEFT,
            new string[] { "data/playerL1.png",
                "data/playerL2.png"});
        currentDirection = RIGHT;
        x = 50;
        y = 120;
        xSpeed = ySpeed = 8;
        width = 63;
        height = 96;
    }

    public void MoveRight(Room room)
    {
        if (jumping || falling) return;

        if (room.CanMoveTo(x + xSpeed,
                    y,
                    x + width + xSpeed,
                    y + height))
        {
            x += xSpeed;
            ChangeDirection(RIGHT);
            NextFrame();
        }
    }

    public void MoveLeft(Room room)
    {
        if (jumping || falling) return;

        if (room.CanMoveTo(x - xSpeed,
                    y,
                    x + width - xSpeed,
                    y + height))
        {
            x -= xSpeed;
            ChangeDirection(LEFT);
            NextFrame();
        }
    }


    // Starts the jump sequence
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

    // Used when the player must move on his own, e.g. jumping
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
}
