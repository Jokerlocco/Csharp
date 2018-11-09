// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 003, 25-oct-18   Ivan Lazcano: Game can end, fires, enemies can die
// 002, 11-Oct-18   Jorge Calzada: Two enemys
// 001, 08-Oct-18   Nacho: Almost empty skeleton

public class GalaxianSDL
{
    public static void Main(string[] args)
    {

        SdlHardware.Init(1024, 768, 24, false);

        int xShip = 500;
        int yShip = 500;
        int xEnemy = 400;
        int yEnemy = 200;
        bool EnemyAlive = true;
        int xEnemy2 = 200;
        int yEnemy2 = 250;
        bool Enemy2Alive = true;
        int enemySpeed = 5;
        int enemySpeed2 = -3;
        int xFire = xShip;
        int yFire = yShip + 25;
        int fireSpeed = 5;
        bool activeFire = false;
        bool finished = false;

        Image ship = new Image("data/ship.png");//45x51p
        Image enemy1 = new Image("data/enemy1a.png");//33x24p
        Image enemy2 = new Image("data/enemy2a.png");//33x24p
        Image fire = new Image("data/fire.png");//3x12p

        do
        {
            // Draw elements
            SdlHardware.ClearScreen();
            if (EnemyAlive)
                SdlHardware.DrawHiddenImage(enemy1, xEnemy, yEnemy);
            if (Enemy2Alive)
                SdlHardware.DrawHiddenImage(enemy2, xEnemy2, yEnemy2);
            SdlHardware.DrawHiddenImage(ship, xShip, yShip);
            if (activeFire)
                SdlHardware.DrawHiddenImage(fire, xFire, yFire);
            SdlHardware.ShowHiddenScreen();

            // Process user input
            if (SdlHardware.KeyPressed(SdlHardware.KEY_ESC))
                finished = true;
            if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
                xShip += 10;
            if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT))
                xShip -= 10;
            if (SdlHardware.KeyPressed(SdlHardware.KEY_SPC) && (!activeFire))
            {
                activeFire = true;
                xFire = xShip + 21;//Fires from the center of the ship
                yFire = yShip + 1;
            }

            // Update world
            if (EnemyAlive)
            {
                if ((xEnemy <= 50) || (xEnemy >= 950))
                    enemySpeed = -enemySpeed;
                xEnemy += enemySpeed;
            }
            if (Enemy2Alive)
            {
                if ((xEnemy2 <= 50) || (xEnemy2 >= 950))
                    enemySpeed2 = -enemySpeed2;
                xEnemy2 += enemySpeed2;
            }
            if (activeFire)
                yFire -= fireSpeed;

            // Check game status
            if (yFire < 20)
                activeFire = false;

            if ((xEnemy < (xFire + 3) && (xEnemy + 33) > xFire) &&
                    ((yEnemy + 24) > yFire && (yEnemy < (yFire + 12))))
            {
                EnemyAlive = false;
                activeFire = false;
            }
            if ((xEnemy2 < (xFire + 3) && (xEnemy2 + 33) > xFire) &&
                    ((yEnemy2 + 24) > yFire && (yEnemy2 < (yFire + 12))))
            {
                Enemy2Alive = false;
                activeFire = false;
            }

            if ((!Enemy2Alive) && (!EnemyAlive))
                finished = true;
            // (Not yet)

            // Pause until next frame
            SdlHardware.Pause(20);
        }
        while (!finished);
    }
}
