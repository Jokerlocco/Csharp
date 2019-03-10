using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

/// <summary>
/// This is the main type for your game.
/// </summary>
public class GameMain
{
    private Texture2D player;
    private Texture2D enemy;
    private Vector2 playerPosition;
    private Vector2 enemyPosition;
    private SpriteFont font;
    private float playerSpeed, enemySpeed;
    private int maxX, maxY;

    public GameMain(int maxX, int maxY)
    {
        this.maxX = maxX;
        this.maxY = maxY;
        playerPosition = new Vector2(maxX / 2, 600);
        playerSpeed = 300f;
        enemySpeed = 200f;
        enemyPosition = new Vector2(400, 200);
    }

    public void LoadContent(ContentManager Content)
    {
        player = Content.Load<Texture2D>("ship");
        enemy = Content.Load<Texture2D>("enemy1a");
        font = Content.Load<SpriteFont>("Joystix");
    }

    public void Update(GameTime gameTime)
    {
        // Add your update logic here
        var kstate = Keyboard.GetState();

        if (kstate.IsKeyDown(Keys.Left))
            playerPosition.X -= playerSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

        if (kstate.IsKeyDown(Keys.Right))
            playerPosition.X += playerSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

        if (playerPosition.X < 0)
            playerPosition.X = 0;

        if (playerPosition.X > maxX - player.Width)
            playerPosition.X = maxX - player.Width;

        enemyPosition.X += enemySpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
        if (enemyPosition.X < 0)
        {
            enemyPosition.X = 0;
            enemySpeed = -enemySpeed;
        }
        if (enemyPosition.X > maxX - enemy.Width)
        {
            enemyPosition.X = maxX - enemy.Width;
            enemySpeed = -enemySpeed;
        }
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(enemy, enemyPosition, Color.White);
        spriteBatch.Draw(player, playerPosition, Color.White);
        spriteBatch.DrawString(font, "Score", new Vector2(100, 100), Color.White);
    }
}
