// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 025, 17-Abr-19   Nacho: Created class EnemyRed

class EnemyRed : Enemy
{
    public EnemyRed(int x, int y) :
        base(x, y)
    {
        LoadSequence(RIGHT,
            new string[] { "data/enemy3a.png",
                "data/enemy3b.png"});
    }
}