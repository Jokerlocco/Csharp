# sv2018-programming

## Nodes Of Yesod 007

### Collisions with background + animation

In order to check collisions with the background, we can add a new method
to the class Room, which will check if a certain rectangle overlaps with
any background tile which cannot be crossed:

```
public bool CanMoveTo(int x1, int y1, int x2, int y2)
{
	for (int column = 0; column < mapWidth; column++)
	{
		for (int row = 0; row < mapHeight; row++)
		{
			char tile = levelData[row][column];
			if (tile != ' ')  // Space means a tile can be crossed
			{
				int x1tile = leftMargin + column * tileWidth;
				int y1tile = topMargin + row * tileHeight;
				int x2tile = x1tile + tileWidth;
				int y2tile = y1tile + tileHeight;
				if ((x1tile < x2) &&
					(x2tile > x1) &&
					(y1tile < y2) &&
					(y2tile > y1) // Collision as bouncing boxes
					)
					return false;
			}
		}
	}
	return true;
}
```

And we can call it from Game:


```
void CheckUserInput()
{
	if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
	{
		if(room.CanMoveTo(player.GetX() + player.GetSpeedX(), 
				player.GetY(),
				player.GetX() + player.GetWidth() + player.GetSpeedX(), 
				player.GetY() + player.GetHeight()))
			player.MoveRight();
	}
	
	// ...
```


Adding an animation for the player is also easy: we can use "LoadSequence"
instead of "LoadImage":

```
class Player : Sprite
{
    public Player()
    {
       
        LoadSequence(RIGHT,
            new string[] { "data/playerR1.png",
                "data/playerR2.png"});
        LoadSequence(LEFT,
            new string[] { "data/playerL1.png",
                "data/playerL2.png"});
        currentDirection = RIGHT;
```

And change the animation frame each time we are told to move:

```
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
```
