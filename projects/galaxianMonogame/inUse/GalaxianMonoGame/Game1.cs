using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GalaxianMonoGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D player;
        Texture2D enemy;
        Vector2 playerPosition;
        Vector2 enemyPosition;
        private SpriteFont font;
        float playerSpeed, enemySpeed;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // Add your initialization logic here
            playerPosition = new Vector2(
                graphics.PreferredBackBufferWidth / 2, 600);
            playerSpeed = 300f;
            enemySpeed = 200f;
            enemyPosition = new Vector2(400, 200);

            graphics.PreferredBackBufferWidth = 1280;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = 720;   // set this value to the desired height of your window
            graphics.ApplyChanges();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            player = Content.Load<Texture2D>("ship");
            enemy = Content.Load<Texture2D>("enemy1a");
            font = Content.Load<SpriteFont>("Joystix");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Add your update logic here
            var kstate = Keyboard.GetState();

            if (kstate.IsKeyDown(Keys.Left))
                playerPosition.X -= playerSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kstate.IsKeyDown(Keys.Right))
                playerPosition.X += playerSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kstate.IsKeyDown(Keys.F8))
            {
                graphics.IsFullScreen = !graphics.IsFullScreen;
                graphics.ApplyChanges();
            }

            if (playerPosition.X < 0)
                playerPosition.X = 0;

            if (playerPosition.X > graphics.PreferredBackBufferWidth - player.Width)
                playerPosition.X = graphics.PreferredBackBufferWidth - player.Width;

            enemyPosition.X += enemySpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (enemyPosition.X < 0)
            {
                enemyPosition.X = 0;
                enemySpeed = -enemySpeed;
            }
            if (enemyPosition.X > graphics.PreferredBackBufferWidth - enemy.Width)
            {
                enemyPosition.X = graphics.PreferredBackBufferWidth - enemy.Width;
                enemySpeed = -enemySpeed;
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // Drawing code
            spriteBatch.Begin();
            spriteBatch.Draw(enemy, enemyPosition, Color.White);
            spriteBatch.Draw(player, playerPosition, Color.White);
            spriteBatch.DrawString(font, "Score", new Vector2(100, 100), Color.Black);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
