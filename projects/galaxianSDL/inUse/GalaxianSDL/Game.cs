// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 031, 15-May-19   Nacho: Two sounds are played (intro + fire)
// 029, 06-May-19   Nacho: Full screen can be toggled by pressing F2 (sloooow)
// 026, 17-Abr-19   Nacho: Attack, first approach: enemies fall and collide
// 025, 17-Abr-19   Nacho: Uses Enemy + EnemyYellow + EnemyRed + EnemyPurple 
// 024, 17-Abr-19   Nacho: Background is a class instead of an image
// 023, 12-Mar-19   Nacho: activeMouse defaults to False
// 021, 26-Feb-19   Nacho: Enemies can Die with explosion
// 016, 21-Feb-19   Calzada: Use Player class
// 015, 21-Feb-19   Marín + Rebollo: Cheats
// 014, 21-Feb-19   Ivan y Pablo: Ships move with joystick
// 013, 21-Feb-19   Sergio y Diego: Use Enemy class
// 010, 21-Feb-19   Ivan y Pablo: Ships move with mouse
// 009, 21-Feb-19   Nacho: Static background
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
    const int SIZEENEMY = 60;

    Player player = new Player();

    int speedForAllEnemies;
    int xEnemy, yEnemy;
    bool finished;
    int aliveEnemies;
    int score;
    int spriteCount;
    bool activeMouse;
    bool activeJoystick;

    Background back;
    Font font18;
    Enemy[] e;

    Sound introSound, fireSound;

    string cheatInfo;
    int cheatTime;

    public Game()
    {
        activeMouse = false;
        activeJoystick = false;

        player.MoveTo(500, 600);

        e = new Enemy[SIZEENEMY];

        int currentEnemy = 0;
        for (int row = 0; row < 6; row++)
            for (int col = 0; col < 10; col++)
            {
                yEnemy = 100 + 50 * row;
                xEnemy = 100 + 40 * col;
                if (row == 0)
                    e[currentEnemy] = new EnemyYellow(xEnemy, yEnemy);
                else if (row == 1)
                    e[currentEnemy] = new EnemyRed(xEnemy, yEnemy);
                else if (row == 2)
                    e[currentEnemy] = new EnemyPurple(xEnemy, yEnemy);
                else
                    e[currentEnemy] = new Enemy(xEnemy, yEnemy);

                currentEnemy++;
            }

        speedForAllEnemies = 3;

        finished = false;
        aliveEnemies = SIZEENEMY;
        score = 0;
        spriteCount = 0;

        font18 = new Font("data/Joystix.ttf", 18);
        back = new Background();

        introSound = new Sound("data/galaxianIntro.mp3");
        fireSound = new Sound("data/fire.mp3");
    }


    public void DrawElements()
    {
        SdlHardware.ClearScreen();
        back.DrawOnHiddenScreen();

        SdlHardware.WriteHiddenText(("Score: " + score),
                40, 10,
                0xCC, 0xCC, 0xCC,
                font18);

        if (cheatTime > 0)
        {
            SdlHardware.WriteHiddenText(cheatInfo,
                   40, 720,
                   0xCC, 0xCC, 0xCC,
                   font18);
            cheatTime--;
        }

        for (int i = 0; i < SIZEENEMY; i++)
        {
            e[i].DrawOnHiddenScreen();
        }

        player.DrawOnHiddenScreen();

        if (player.GetFire().IsVisible())
        {
            player.GetFire().Move();
            player.GetFire().DrawOnHiddenScreen();
        }

        SdlHardware.ShowHiddenScreen();
    }


    public void ProcessUserInput()
    {
        if (SdlHardware.KeyPressed(SdlHardware.KEY_ESC))
            finished = true;
        if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT)
            || SdlHardware.JoystickMovedRight())
        {
            player.MoveRight();
        }
        if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT)
            || SdlHardware.JoystickMovedLeft())
        {
            player.MoveLeft();
        }
        if ((SdlHardware.KeyPressed(SdlHardware.KEY_SPC)
             || SdlHardware.JoystickMovedUp()
             || (SdlHardware.MouseClicked() && activeMouse))
            && (!player.GetFire().IsVisible()))
        {
            fireSound.PlayOnce();
            player.Shoot();
        }

        // And F2 toggles Full Screen mode
        if (SdlHardware.KeyPressed(SdlHardware.KEY_F2))
            SdlHardware.ToggleFullScreen();

        if (SdlHardware.KeyPressed(SdlHardware.KEY_T))
        {
            if (SdlHardware.KeyPressed(SdlHardware.KEY_V))
                ApplyCheat('V');
            if (SdlHardware.KeyPressed(SdlHardware.KEY_N))
                ApplyCheat('N');
            if (SdlHardware.KeyPressed(SdlHardware.KEY_R))
                ApplyCheat('R');
            if (SdlHardware.KeyPressed(SdlHardware.KEY_P))
                ApplyCheat('P');
            if (SdlHardware.KeyPressed(SdlHardware.KEY_D))
                ApplyCheat('D');
        }

        if (activeMouse)
            player.MoveTo(SdlHardware.GetMouseX(), player.GetY());

        if (SdlHardware.KeyPressed(SdlHardware.KEY_O))
        {
            if (activeMouse)
            {
                activeMouse = false;
                activeJoystick = true;
            }
            else if (activeJoystick)
            {
                activeJoystick = false;
            }
            else
                activeMouse = true;
        }


    }

    public void ApplyCheat(char code)
    {
        switch (code)
        {
            case 'V':
                //TO DO...
                break;
            case 'N':
                //TO DO...
                break;
            case 'R':
                cheatInfo = "Despacito y con buena letra";
                foreach (Enemy ene in e)
                    ene.SetSpeed(1, 1);
                break;
            case 'P':
                cheatInfo = "Vamos a poner esto por aqui...";
                score += 1000;
                break;
            case 'D':
                cheatInfo = "¡Paro! Espera, ¿esto no era Final Fantasy?";
                foreach (Enemy ene in e)
                    ene.SetSpeed(0, 0);
                break;
        }
        cheatTime = 40;
    }

    public void UpdateWorld()
    {
        back.Move();

        for (int i = 0; i < SIZEENEMY; i++)
        {
            if (e[i].IsVisible())
                e[i].Move();
        }

        spriteCount++;
        if (spriteCount > 20)
            spriteCount = -20;
    }


    public void CheckGameStatus()
    {
        for (int i = 0; i < SIZEENEMY; i++)  
        {
            // And enemy collides with the player?
            if (e[i].CollisionsWith(player))
            {
                finished = true;
            }

            // Fire hits any enemy?
            if (player.GetFire().IsVisible() && e[i].IsVisible() &&
                (e[i].GetX() < (player.GetFire().GetX() + 3) &&
                (e[i].GetX() + 33) > player.GetFire().GetX()) &&
                ((e[i].GetY() + 24) > player.GetFire().GetY() &&
                (e[i].GetY() < (player.GetFire().GetY() + 12))))
            {
                //e[i].Hide();
                e[i].Die();
                player.GetFire().Hide();
                aliveEnemies--;
                score += 10;
                if (aliveEnemies == 0)
                    finished = true;
            }
        }
    }


    public void PauseUntilNextFrame()
    {
        SdlHardware.Pause(20);
    }


    public void Run()
    {
        introSound.PlayOnce();
        SdlHardware.Pause(2000);
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