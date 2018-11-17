// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 005, 15-nov-18   A.Navarro, C.Francés, K.Marín: Many enemies (struct)
// 004, 09-nov-18   María Gonzáles: Many enemies
// 003, 25-oct-18   Ivan Lazcano: Game can end, fire, enemies can die
// 002, 11-Oct-18   Jorge Calzada: Two enemys
// 001, 08-Oct-18   Nacho: Almost empty skeleton

public class GalaxianSDL
{
    struct enemy
    {
        public int x;
        public int y;
        public bool alive;
    }

    public static void Main(string[] args)
    {

        SdlHardware.Init(1024, 768, 24, false);

        int xShip = 500;
        int yShip = 500;

        const int SIZEENEMY = 20;
        enemy[] e = new enemy[SIZEENEMY];

        for (int i = 0; i < SIZEENEMY; i++)
        {
            e[i].x = 100 + 30 * i;
            if (i % 2 == 0)
                e[i].y = 200;
            else
                e[i].y = 300;
            e[i].alive = true;
        }

        int speedForAllEnemies = 3;

        int xFire = xShip;
        int yFire = yShip + 25;
        int fireSpeed = 5;
        bool activeFire = false;
        bool finished = false;
        int aliveEnemies = SIZEENEMY;

        Image ship = new Image("data/ship.png");//45x51p
        Image enemy = new Image("data/enemy1a.png");//33x24p
        Image fire = new Image("data/fire.png");//3x12p

        do
        {
            // Draw elements
            SdlHardware.ClearScreen();
            for (int i = 0; i < SIZEENEMY; i++)
            {
                if (e[i].alive)
                    SdlHardware.DrawHiddenImage(enemy, e[i].x, e[i].y);
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
                if (e[i].alive)
                    e[i].x = e[i].x + speedForAllEnemies;
            }
            for (int i = 0; i < SIZEENEMY; i++)
            {
                if (e[i].x <= 50)
                {
                    speedForAllEnemies = 3;
                }
                else if (e[i].x >= 950)
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
                if (activeFire && e[i].alive &&
                    (e[i].x < (xFire + 3) && (e[i].x + 33) > xFire) &&
                    ((e[i].y + 24) > yFire && (e[i].y < (yFire + 12))))
                {
                    e[i].alive = false;
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
