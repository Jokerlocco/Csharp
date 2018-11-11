// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 004, 09-nov-18   María Gonzáles: Many enemies
// 003, 25-oct-18   Ivan Lazcano: Game can end, fire, enemies can die
// 002, 11-Oct-18   Jorge Calzada: Two enemys
// 001, 08-Oct-18   Nacho: Almost empty skeleton

public class GalaxianSDL
{
    public static void Main(string[] args)
    {

        SdlHardware.Init(1024, 768, 24, false);

        int xShip = 500;
        int yShip = 500;

        const int SIZEENEMY = 20;
        int[] xEnemy = new int[SIZEENEMY];
        int[] yEnemy = new int[SIZEENEMY];
        int speedForAllEnemies = 3;
        bool[] enemyAlive = new bool[SIZEENEMY];
        int aliveEnemies = SIZEENEMY;

        for (int i = 0; i < SIZEENEMY; i++)
        {
            enemyAlive[i] = true;
            xEnemy[i] = 100 + 30 * i;
            if (i % 2 == 0)
                yEnemy[i] = 200;
            else
                yEnemy[i] = 300;
        }

        int xFire = xShip;
        int yFire = yShip + 25;
        int fireSpeed = 5;
        bool activeFire = false;
        bool finished = false;

        Image ship = new Image("data/ship.png");//45x51p
        Image enemy = new Image("data/enemy1a.png");//33x24p
        Image fire = new Image("data/fire.png");//3x12p

        do
        {
            // Draw elements
            SdlHardware.ClearScreen();
            for (int i = 0; i < SIZEENEMY; i++)
            {
                if (enemyAlive[i])
                    SdlHardware.DrawHiddenImage(enemy, xEnemy[i], yEnemy[i]);
            }

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
            for (int i = 0; i < SIZEENEMY; i++)
            {
                if (enemyAlive[i])
                    xEnemy[i] = xEnemy[i] + speedForAllEnemies;
            }
            for (int i = 0; i < SIZEENEMY; i++)
            {
                if (xEnemy[i] <= 50)
                {
                    speedForAllEnemies = 3;
                }
                else if (xEnemy[i] >= 950)
                {
                    speedForAllEnemies = -3;
                }
            }

            if (yFire <= 2)
            {
                yFire = 21;
                activeFire = false;
            }
            if (activeFire)
                yFire -= fireSpeed;


            // Check game status
            if (yFire < 20)  //  Fire must disappear?
                activeFire = false;

            for (int i = 0; i < SIZEENEMY; i++)  // Fire hits any enemy?
                if (activeFire && enemyAlive[i] &&
                    (xEnemy[i] < (xFire + 3) && (xEnemy[i] + 33) > xFire) &&
                    ((yEnemy[i] + 24) > yFire && (yEnemy[i] < (yFire + 12))))
                {
                    enemyAlive[i] = false;
                    activeFire = false;
                    aliveEnemies--;
                    if (aliveEnemies == 0)
                        finished = true;
                }

            // Pause until next frame
            SdlHardware.Pause(20);
        }
        while (!finished);
    }
}
