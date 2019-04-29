// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 024, 17-Abr-19   Nacho: Moving background
// 009, 21-Feb-19   Nacho: Empty skeleton

class Background : Sprite
{
    public Background()
    {
        LoadImage("data/backgroundLong.png");
        x = 100;
        y = -672;
    }

    public override void Move()
    {
        y++;
        if (y >= 0)
            y = -672;
    }
}
