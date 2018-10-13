// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 002, 11-Oct-18   Jorge Calzada: Two enemys
// 001, 08-Oct-18   Nacho: Almost empty skeleton

public class GalaxianSDL
{
    public static void Main(string[] args)
    {

        SdlHardware.Init(1024, 768, 24, false);

        int xShip = 500;
        int xEnemy = 400;
        int xEnemy2 = 200;
        int enemySpeed = 5;
        int enemySpeed2 = -3;
        int finished = 0;

        Image ship = new Image("data/ship.png");
        Image enemy1 = new Image("data/enemy1a.png");
        Image enemy2 = new Image("data/enemy2a.png");

        do
        {
            // Draw elements
            SdlHardware.ClearScreen();
            SdlHardware.DrawHiddenImage(enemy1, xEnemy, 200);
            SdlHardware.DrawHiddenImage(enemy2, xEnemy2, 250);
            SdlHardware.DrawHiddenImage(ship, xShip, 500);
            SdlHardware.ShowHiddenScreen();

            // Process user input
            if (SdlHardware.KeyPressed(SdlHardware.KEY_ESC))
                finished = 1;
            if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
                xShip += 10;
            if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT))
                xShip -= 10;

            // Update world
            if ((xEnemy <= 50) || (xEnemy >= 950))
                enemySpeed = -enemySpeed;
            xEnemy += enemySpeed;

            if ((xEnemy2 <= 50) || (xEnemy2 >= 950))
                enemySpeed2 = -enemySpeed2;
            xEnemy2 += enemySpeed2;

            // Check game status
            // (Not yet)

            // Pause until next frame
            SdlHardware.Pause(20);
        }
        while (finished == 0);
    }
}
