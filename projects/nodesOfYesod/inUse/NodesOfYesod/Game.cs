/**
 * Game.cs - Nodes Of Yesod, game logic
 * 
 * Changes:
 * 0.11, 08-02-2019: Several lives. Level and player are reset. Game over text.
 * 0.10, 10-02-2019: Panel is displayed (still empty). Help can de displayed
 * 0.09, 29-01-2019: 
 *   The room knows the player and can move it, if we switch to another room
 * 0.08, 26-01-2019: 
 *   Enemies belong to each Room
 *   Player falls (gravity)
 *   Player can jump
 *   Player collision checking moved from class Game to class Player
 * 0.07, 25-01-2019: 
 *   Player only moves to a valid position. 
 *   Init becomes a constructor
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
    //protected int numEnemies;
    //protected Enemy[] enemies;
    protected Room room;
    protected bool finished;
    protected Font font18, font60;
    protected InfoPanel panel;

    public Game()
    {
        player = new Player();
        player.MoveTo(200, 100);

        finished = false;

        font18 = new Font("data/Joystix.ttf", 18);
        font60 = new Font("data/Joystix.ttf", 60);
        room = new Room();
        room.SetPlayer(player);
        panel = new InfoPanel();
    }

    void UpdateScreen()
    {
        SdlHardware.ClearScreen();
        room.DrawOnHiddenScreen();

        SdlHardware.WriteHiddenText("Score:                  Press H for Help",
            140, 10,
            0xCC, 0xCC, 0xCC,
            font18);

        player.DrawOnHiddenScreen();
        for (int i = 0; i < room.NumEnemies; i++)
            room.Enemies[i].DrawOnHiddenScreen();
        panel.DrawOnHiddenScreen();
        SdlHardware.ShowHiddenScreen();
    }

    void CheckUserInput()
    {
        if (SdlHardware.KeyPressed(SdlHardware.KEY_SPC))
        {
            if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
                player.JumpRight(room);
            else if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT))
                player.JumpLeft(room);
            else
                player.Jump(room);
        }


        if (SdlHardware.KeyPressed(SdlHardware.KEY_RIGHT))
        {
                player.MoveRight(room);
        }
        if (SdlHardware.KeyPressed(SdlHardware.KEY_LEFT))
        {
                player.MoveLeft(room);
        }

        if (SdlHardware.KeyPressed(SdlHardware.KEY_H))
        {
            HelpScreen help = new HelpScreen();
            help.Run();
        }

        if (SdlHardware.KeyPressed(SdlHardware.KEY_ESC))
            finished = true;
    }

    void UpdateWorld()
    {
        // Move player: gravity or jump
        player.Move(room);
        // Move enemies, background, etc 
        for (int i = 0; i < room.NumEnemies; i++)
            room.Enemies[i].Move();
    }

    void CheckGameStatus()
    {
        // Check collisions and apply game logic
        for (int i = 0; i < room.NumEnemies; i++)
            if (player.CollisionsWith(room.Enemies[i]))
            {
                panel.Lives--;
                room.Reload();
                // TO DO: Choose a per-room "safe position"
                player.MoveTo(200, 100); 
                if (panel.Lives <= 0)
                    finished = true;
            }
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
        do
        {
            UpdateScreen();
            CheckUserInput();
            UpdateWorld();
            PauseUntilNextFrame();
            CheckGameStatus();
        }
        while (!finished);

        SdlHardware.WriteHiddenText("GAME OVER",
            296, 324,
            50, 50, 50,
            font60);
        SdlHardware.WriteHiddenText("GAME OVER",
            300, 320,
            0xC0, 0xC0, 0,
            font60);
        SdlHardware.ShowHiddenScreen();
        SdlHardware.Pause(2000);

        UpdateHighscore();
    }
}
