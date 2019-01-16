/**
 * Enemy.cs - Nodes Of Yesod, a simple enemy
 * 
 * Changes:
 * 0.04, 16-01-2019: Class created (only constructor)
 */

class Enemy : Sprite
{
    public Enemy()
    {
        LoadImage("data/enemy.png");
        width = 64;
        height = 64;
    }
}

