// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 025, 17-Abr-19   Nacho: Created class EnemyPurple

class EnemyPurple : Enemy
{
    public EnemyPurple(int x, int y):
        base(x,y)
    {
        LoadSequence(RIGHT,
            new string[] { "data/enemy2a.png",
                "data/enemy2b.png"});
    }
}
