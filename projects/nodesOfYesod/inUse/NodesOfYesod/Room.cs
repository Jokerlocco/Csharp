/**
 * Room.cs - Nodes Of Yesod, a single room in the game map
 * 
 * Changes:
 * 0.09, 29-01-2019: 
 *      Data from each room is taken from Map.cs
 *      CanMoveTo can move the player if we switch to another room
 * 0.08, 26-01-2019: Enemies are placed in the map
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

    protected int mapRow = 0, mapColumn = 0;
    protected Player player;

    const int MAX_ENEMIES = 10;
    public int NumEnemies = 0;
    public Enemy[] Enemies;

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

        GetFromMap(0, 0);
    }

    public void SetPlayer(Player p)
    {
        player = p;
    }

    public void GetFromMap(int mapColumn, int mapRow)
    {
        for (int i = 0; i < mapHeight; i++)
        {
            levelData[i] = Map.levelData[mapColumn, mapRow, i];
        }

        // And let's extract the info about the enemies from the map
        Enemies = new Enemy[MAX_ENEMIES];
        NumEnemies = 0;
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
                        Remove(col, 1).Insert(col, " ");
                }
            }
        }
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
        if (x2 > leftMargin + mapWidth * tileWidth) // Do we have to move right?
        {
            mapColumn++;
            GetFromMap(mapRow, mapColumn);
            player.MoveTo(leftMargin, player.GetY());
        }

        if (x1 < leftMargin) // Do we have to move left?
        {
            mapColumn--;
            GetFromMap(mapRow, mapColumn);
            player.MoveTo(leftMargin + mapWidth * tileWidth - player.GetWidth(), 
                player.GetY());
        }

        if (y2 > topMargin+mapHeight*tileHeight) // Do we have to fall?
        {
            mapRow++;
            GetFromMap(mapRow, mapColumn);
            player.MoveTo(player.GetX(), topMargin);
        }

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

