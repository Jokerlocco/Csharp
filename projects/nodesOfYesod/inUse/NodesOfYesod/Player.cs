/**
 * Player.cs - Nodes Of Yesod, player-controlled sprite
 * 
 * Changes:
 * 0.04, 16-01-2019: Class created (constructor + move 4 directions)
 */

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
