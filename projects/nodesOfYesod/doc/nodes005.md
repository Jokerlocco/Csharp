# sv2018-programming

## Nodes Of Yesod 005

### Room

Now we are going to include a new class, called "Room", which will represent
the background for a "room" in the cave, using tiles:

```
class Room
{
    protected Image wallL1, wallL2, floor1, floor2, column, 
        platform1, platform2;

    protected int mapHeight = 11, mapWidth = 16;
    protected int tileWidth = 32, tileHeight = 32;
    protected int leftMargin = 100, topMargin = 50;

    protected string[] levelData =
    {
        "1                ",
        "2                ",
        "1                ",
        "1                ",
        "2                ",
        "2                ",
        "1[]              ",
        "2||         []   ",
        "1||         ||   ",
        "1||         ||   ",
        "AABAAAABBABAAABAA"};

    public Room()
    {
        wallL1 = new Image("data/tile-wallL1.png");
        wallL2 = new Image("data/tile-wallL2.png");
        floor1 = new Image("data/tile-floor1.png");
        floor2 = new Image("data/tile-floor2.png");
        platform1 = new Image("data/tile-platf1.png");
        platform2 = new Image("data/tile-platf2.png");
        column = new Image("data/tile-column1.png");
    }

    public void DrawOnHiddenScreen()
    {
        for (int row = 0; row < mapHeight; row++)
        {
            for (int col = 0; col < mapWidth; col++)
            {
                int posX = col * tileWidth + leftMargin;
                int posY = row * tileHeight + topMargin;
                switch (levelData[row][col])
                {
                    case '1': SdlHardware.DrawHiddenImage(wallL1, posX, posY); break;
                    case '2': SdlHardware.DrawHiddenImage(wallL2, posX, posY); break;
                    case 'A': SdlHardware.DrawHiddenImage(floor1, posX, posY); break;
                    case 'B': SdlHardware.DrawHiddenImage(floor2, posX, posY); break;
                    case '|': SdlHardware.DrawHiddenImage(column, posX, posY); break;
                    case '[': SdlHardware.DrawHiddenImage(platform1, posX, posY); break;
                    case ']': SdlHardware.DrawHiddenImage(platform2, posX, posY); break;
                }
            }
        }
    }
}
```

And the changes in Main will be little more than creating a Room and 
displaying it (and we can also remove "static" from all methods):


```
protected Room room;

// ...

void Init()
{
	// ...
	room = new Room();
}

void UpdateScreen()
{
	SdlHardware.ClearScreen();
	room.DrawOnHiddenScreen();
	// ...
```

