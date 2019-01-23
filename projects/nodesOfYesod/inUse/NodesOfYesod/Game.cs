/**
 * Game.cs - Nodes Of Yesod, game logic
 * 
 * Changes:
 * 0.06, 23-01-2019: Enemies can move. Collisions checked
 * 0.05, 18-01-2019: 
 *   Memory leak in update screen (font loading) fixed
 *   Removed code commented in the previous version
 *   Removed unnecesary "static" clauses
 *   Room is displayed as background
 * 0.04, 16-01-2019: Uses classes Player & Enemy
 * 0.03, 14-01-2019: Main & Hardware init moved to NodeOfYesod
 * 0.02, 29-11-2018: Split into functions
 * 0.01, 01-nov-2014: Initial version, drawing player 2, enemies, 
 *   allowing the user to move to the right
 */

using System;

class Game
{
    protected Player player;
    protected int numEnemies;
    protected Enemy[] enemies;
    protected Room room;
    protected bool finished;
    protected Font font18;

    void Init()
    {
        player = new Player();

        numEnemies = 2;
        enemies = new Enemy[numEnemies];
        for (int i = 0; i < numEnemies; i++)
        {
            enemies[i] = new Enemy();
        }

        finished = false;

        Random rnd = new Random();
        for (int i = 0; i < numEnemies; i++)
        {
            enemies[i].MoveTo(rnd.Next(200, 800),
                rnd.Next(50, 600));
            enemies[i].SetSpeed( rnd.Next(1, 5),
                rnd.Next(1, 5));
        }

        font18 = new Font("data/Joystix.ttf", 18);
        room = new Room();
    }

    void UpdateScreen()
    {
        SdlHardware.ClearScreen();
        room.DrawOnHiddenScreen();

        SdlHardware.WriteHiddenText("Score: ",
            40, 10,
            0xCC, 0xCC, 0xCC,
            font18);

        player.DrawOnHiddenScreen();
        for (int i = 0; i < numEnemies; i++)
            enemies[i].DrawOnHiddenScreen();
        SdlHardware.ShowHiddenScreen();
    }

    void CheckUserInput()
    {
        if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
            player.MoveRight();
        if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT))
            player.MoveLeft();
        if (SdlHardware.KeyPressed(SdlHardware.KEY_UP))
            player.MoveUp();
        if (SdlHardware.KeyPressed(SdlHardware.KEY_DOWN))
            player.MoveDown();

        if (SdlHardware.KeyPressed(SdlHardware.KEY_ESC))
            finished = true;
    }

    void UpdateWorld()
    {
        // Move enemies, background, etc 
        for (int i = 0; i < numEnemies; i++)
            enemies[i].Move();
    }

    void CheckGameStatus()
    {
        // Check collisions and apply game logic
        for (int i = 0; i < numEnemies; i++)
            if (player.CollisionsWith(enemies[i]))
                finished = true;
    }

    void PauseUntilNextFrame()
    {
        SdlHardware.Pause(40);
    }

    void UpdateHighscore()
    {
        // Save highest score
        // TO DO
    }

    public void Run()
    {
        Init();

        do
        {
            UpdateScreen();
            CheckUserInput();
            UpdateWorld();
            PauseUntilNextFrame();
            CheckGameStatus();
        }
        while (!finished);

        UpdateHighscore();
    }
}
