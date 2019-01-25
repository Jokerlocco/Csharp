/**
 * Room.cs - Nodes Of Yesod, a single room in the game map
 * 
 * Changes:
 * 0.07, 25-01-2019: Added "CanMoveTo", to check if a 
 *      certain position can be crossed
 * 0.06, 23-01-2019: Tiles 50% bigger
 * 0.05, 18-01-2019: Class created. Room can be drawn
 */

class Room
{
    protected Image wallL1, wallL2, floor1, floor2, column, 
        platform1, platform2;

    protected int mapHeight = 11, mapWidth = 16;
    protected int tileWidth = 48, tileHeight = 48;
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
}

