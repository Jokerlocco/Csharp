/**
 * Player.cs - Nodes Of Yesod, player-controlled sprite
 * 
 * Changes:
 * 0.07, 25-01-2019: 
 *    Correct width and height, to check collisions properly
 *    Sequence of movement to the right and left
 * 0.04, 16-01-2019: Class created (constructor + move 4 directions)
 */

class Player : Sprite
{
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

    public void MoveRight()
    {
        x += xSpeed;
        ChangeDirection(RIGHT);
        NextFrame();
    }

    public void MoveLeft()
    {
        x -= xSpeed;
        ChangeDirection(LEFT);
        NextFrame();
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
