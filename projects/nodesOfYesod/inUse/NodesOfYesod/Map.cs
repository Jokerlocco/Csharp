/**
 * Map.cs - Nodes Of Yesod, map for the whole game
 * 
 * Changes:
 * 0.09, 29-01-2019: Class created, with a room taken
 *      from Room.cs and two more added
 */

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
                "1      f         ",
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
                "       g        1",
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
                "1[]     g        ",
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
