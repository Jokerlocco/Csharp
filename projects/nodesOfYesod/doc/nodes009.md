# sv2018-programming

## Nodes Of Yesod 009

### Several connected rooms

There are several ways to create more than one room to be visited. We might
simply used a bigger 2D array, if the rooms are connected. Or an array of 
2D arrays. Or an array of objects, if the behaviour of the rooms may differ.
Or we might store the data in text files. Or ...

For example, a 2D array of rooms might look like this:

```
class Map
{
    public static string[,,] levelData =
    {
        { // Upper row
            {  // (0,0)
                "1                ",
                "2           e    ",
                "1                ",
                "1      ABA       ",
                "2           B    ",
                "2                ",
                "1                ",
                "2            BB  ",
                "1      e         ",
                "1                ",
                "1  ABAAB         "
            },

            { // (1,0)
                "                1",
                "                1",
                "                2",
                "                1",
                "  ABAB      e   2",
                "                2",
                "                2",
                "            BB  1",
                "       e        1",
                "                1",
                "      ABBAB     1"
            }
        },
        {  // Lower row
            { // (0,1)
                "1                ",
                "2                ",
                "1                ",
                "1                ",
                "2           e    ",
                "2                ",
                "1[]     e        ",
                "2||         []   ",
                "1||         ||   ",
                "1||         ||   ",
                "AABAAAABBABAAABAA"
            },

            { // (1,1)
                "                1",
                "   e            2",
                "                2",
                "      e         2",
                "            e   1",
                "                1",
                "                2",
                "            []  1",
                "    []      ||  2",
                "    ||      ||  1",
                "AABAAAABBABAAABAA"
            }
        }
    };
}
```

Also, in the class Room, we should be able to get the description from 
such Map:

```
public void GetFromMap(int mapColumn, int mapRow)
{
    for (int i = 0; i < mapHeight; i++)
    {
        levelData[i] = Map.levelData[mapColumn, mapRow, i];
    }
    
    // ...
```

And we might communicate the room and the player, so the player can be
relocated when they enter a different Room:


```
public bool CanMoveTo(int x1, int y1, int x2, int y2)
{
    if (x2 > leftMargin + mapWidth * tileWidth) // Do we have to move right?
    {
        mapColumn++;
        GetFromMap(mapRow, mapColumn);
        player.MoveTo(leftMargin, player.GetY());
    }
    
    // ...
```
