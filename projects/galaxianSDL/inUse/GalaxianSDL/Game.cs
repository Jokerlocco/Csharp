public class GalaxianSDL
{
    public static void Main(string[] args)
    {

        SdlHardware.Init(1024, 768, 24, false);

        int xShip = 500;
        int xEnemy = 400;
        int enemySpeed = 5;
        int finished = 0;

        Image ship = new Image("data/ship.png");
        Image enemy1 = new Image("data/enemy1a.png");

        do
        {
            // Draw elements
            SdlHardware.ClearScreen();
            SdlHardware.DrawHiddenImage(enemy1, xEnemy, 200);
            SdlHardware.DrawHiddenImage(ship, xShip, 500);
            SdlHardware.ShowHiddenScreen();

            // Process user input
            if (SdlHardware.KeyPressed(SdlHardware.KEY_ESC))
                finished = 1;
            if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
                xShip += 10;
            
            // Update world
            xEnemy += enemySpeed;

            // Check game status
            // (Not yet)

            // Pause until next frame
            SdlHardware.Pause(20);
        }
        while (finished == 0);
    }
}
