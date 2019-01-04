// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 008, 04-Ene-19   Nacho: Class created, content extracted from GalaxianSDL
// 007, 06-Dic-18   S. Ruescas: Score, Welcome, EndSCreen, 2 sprites for enemies
// 006, 05-Dic-18   Nacho: Functions
// 005, 15-Nov-18   A.Navarro, C.Francés, K.Marín: Many enemies (struct)
// 004, 09-Nov-18   María Gonzáles: Many enemies
// 003, 25-Oct-18   Ivan Lazcano: Game can end, fire, enemies can die
// 002, 11-Oct-18   Jorge Calzada: Two enemys
// 001, 08-Oct-18   Nacho: Almost empty skeleton

class Game
{
    struct enemy
    {
        public int x;
        public int y;
        public bool alive;
    }

    const int SIZEENEMY = 20;

    int speedForAllEnemies;
    int xShip, yShip;
    int xFire, yFire, fireSpeed;
    bool activeFire, finished;
    int aliveEnemies;
    int score;
    int spriteCount;

    Image shipImage;
    Image enemyImage;
    Image enemyImage2;
    Image fireImage;
    Font font18;
    enemy[] e;


    public Game()
    {      
        xShip = 500;
        yShip = 500;

        const int SIZEENEMY = 20;
        e = new enemy[SIZEENEMY];

        for (int i = 0; i < SIZEENEMY; i++)
        {
            e[i].x = 100 + 30 * i;
            if (i % 2 == 0)
                e[i].y = 200;
            else
                e[i].y = 300;
            e[i].alive = true;
        }

        speedForAllEnemies = 3;

        xFire = xShip;
        yFire = yShip + 25;
        fireSpeed = 5;
        activeFire = false;
        finished = false;
        aliveEnemies = SIZEENEMY;
        score = 0;
        spriteCount = 0;
        
        shipImage = new Image("data/ship.png");//45x51p
        enemyImage = new Image("data/enemy1a.png");//33x24p
        enemyImage2 = new Image("data/enemy1b.png");//33x24p
        fireImage = new Image("data/fire.png");//3x12p
        font18 = new Font("data/Joystix.ttf", 18);
    }


    public void DrawElements()
    {
        SdlHardware.ClearScreen();

        SdlHardware.WriteHiddenText(("Score: " + score),
                40, 10,
                0xCC, 0xCC, 0xCC,
                font18);

        for (int i = 0; i < SIZEENEMY; i++)
        {
            if (e[i].alive)
            {
                if (spriteCount > 0)
                    SdlHardware.DrawHiddenImage(enemyImage, e[i].x, e[i].y);
                else
                    SdlHardware.DrawHiddenImage(enemyImage2, e[i].x, e[i].y);
            }
        }

        SdlHardware.DrawHiddenImage(shipImage, xShip, yShip);

        if (activeFire)
            SdlHardware.DrawHiddenImage(fireImage, xFire, yFire);


        SdlHardware.ShowHiddenScreen();
    }


    public void ProcessUserInput()
    {
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
    }


    public void UpdateWorld()
    {
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
        spriteCount++;
        if (spriteCount > 20)
            spriteCount = -20;
    }


    public void CheckGameStatus()
    {
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
                score += 10;
                if (aliveEnemies == 0)
                    finished = true;
            }
    }


    public void PauseUntilNextFrame()
    {
        SdlHardware.Pause(20);
    }


    public void Run()
    {
        do
        {
            DrawElements();
            ProcessUserInput();
            UpdateWorld();
            CheckGameStatus();
            PauseUntilNextFrame();
        }
        while (!finished);
    }

}

