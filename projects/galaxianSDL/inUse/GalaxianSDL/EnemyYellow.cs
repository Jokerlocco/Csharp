// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 025, 17-Abr-19   Nacho: Created class EnemyYellow

class EnemyYellow : Enemy
{
    public EnemyYellow(int x, int y) :
        base(x, y)
    {
        LoadSequence(RIGHT,
            new string[] { "data/enemy4a.png",
                "data/enemy4a.png"});
    }
}