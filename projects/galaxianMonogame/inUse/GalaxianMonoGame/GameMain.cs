// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 023m,12-Mar-19   Nacho: Adapted to Monogame
// 022, 26-Feb-19   Nacho: The menu in WelcomeScreen is really used
// 008, 04-Ene-19   Nacho: Split into classes
// 007, 06-Dic-18   S. Ruescas: Score, Welcome, EndSCreen, 2 sprites for enemies
// 006, 05-Dic-18   Nacho: Functions
// 005, 15-Nov-18   A.Navarro, C.Francés, K.Marín: Many enemies (struct)
// 004, 09-Nov-18   María Gonzáles: Many enemies
// 003, 25-Oct-18   Ivan Lazcano: Game can end, fire, enemies can die
// 002, 11-Oct-18   Jorge Calzada: Two enemys
// 001, 08-Oct-18   Nacho: Almost empty skeleton

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

public class GameMain
{
    private Player player;
    private Texture2D backgroundImage;
    private SpriteFont font;
    bool finished;
    int aliveEnemies;
    int score;
    private int maxX, maxY;
    Enemy[] e;
    const int SIZEENEMY = 20;
    string cheatInfo;
    int cheatTime;


    public GameMain(int maxX, int maxY)
    {
        this.maxX = maxX;
        this.maxY = maxY;
        e = new Enemy[SIZEENEMY];
    }

    public void LoadContent(ContentManager Content)
    {
        backgroundImage = Content.Load<Texture2D>("background");
        font = Content.Load<SpriteFont>("Joystix18");
        int xEnemy, yEnemy;
        for (int i = 0; i < SIZEENEMY; i++)
        {
            if (i % 2 == 0)
                yEnemy = 200;
            else
                yEnemy = 300;

            xEnemy = 100 + 30 * i;
            e[i] = new Enemy(xEnemy, yEnemy, Content);
        }
        player = new Player(Content);
        player.MoveTo(maxX / 2, 600);
    }

    public void Update(GameTime gameTime)
    {
        ProcessUserInput(gameTime);
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        DrawElements(spriteBatch);
        UpdateWorld();
        CheckGameStatus();
    }

    // ------- Next methods are adapted form the SDL version ---------
     
    public void DrawElements(SpriteBatch sprites)
    {
        sprites.Draw(backgroundImage, new Vector2(100, 50), Color.White);
        sprites.DrawString(font, "Score: " + score, new Vector2(40, 10), Color.Gray);

        if (cheatTime > 0)
        {
            sprites.DrawString(font, cheatInfo,
                   new Vector2(40, 720), Color.Gray);
            cheatTime--;
        }

        for (int i = 0; i < SIZEENEMY; i++)
        {
            e[i].DrawOnHiddenScreen(sprites);
        }

        player.DrawOnHiddenScreen(sprites);

        if (player.GetFire().IsVisible())
        {
            player.GetFire().Move();
            player.GetFire().DrawOnHiddenScreen(sprites);
        }
    }


    public void ProcessUserInput(GameTime gameTime)
    {
        var kstate = Keyboard.GetState();

        if (kstate.IsKeyDown(Keys.Left))
            player.MoveLeft((float)gameTime.ElapsedGameTime.TotalSeconds);

        if (kstate.IsKeyDown(Keys.Right))
            player.MoveRight((float)gameTime.ElapsedGameTime.TotalSeconds);

        if ((kstate.IsKeyDown(Keys.Space))  && (!player.GetFire().IsVisible()))
        {
            player.Shoot();
        }

        if (kstate.IsKeyDown(Keys.T))
        {
            if (kstate.IsKeyDown(Keys.V))
                ApplyCheat('V');
            if (kstate.IsKeyDown(Keys.N))
                ApplyCheat('N');
            if (kstate.IsKeyDown(Keys.R))
                ApplyCheat('R');
            if (kstate.IsKeyDown(Keys.P))
                ApplyCheat('P');
            if (kstate.IsKeyDown(Keys.D))
                ApplyCheat('D');
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
                cheatInfo = "100 puntos extra!";
                score += 1000;
                break;
            case 'D':
                cheatInfo = "Parado! Espera... esto no era Final Fantasy?";
                foreach (Enemy ene in e)
                    ene.SetSpeed(0, 0);
                break;
        }
        cheatTime = 40;
    }

    public void UpdateWorld()
    {
        for (int i = 0; i < SIZEENEMY; i++)
        {
            if (e[i].IsVisible())
                e[i].Move();
        }

        /*
        spriteCount++;
        if (spriteCount > 20)
            spriteCount = -20;
        */
    }


    public void CheckGameStatus()
    {
        for (int i = 0; i < SIZEENEMY; i++)  // Fire hits any enemy?
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
