using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class ScreensManager : Game
{
    GraphicsDeviceManager graphics;
    SpriteBatch spriteBatch;

    GameMain game;
    WelcomeScreen welcome;

    public enum MODE { WELCOME, GAME };
    public MODE currentMode { get; set; }

    public ScreensManager()
    {
        graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";

        game = new GameMain(1280, 720);
        welcome = new WelcomeScreen(this);
        currentMode = MODE.WELCOME;
    }

    /// <summary>
    /// Allows the game to perform any initialization it needs to before starting to run.
    /// This is where it can query for any required services and load any non-graphic
    /// related content.  Calling base.Initialize will enumerate through any components
    /// and initialize them as well.
    /// </summary>
    protected override void Initialize()
    {
        graphics.PreferredBackBufferWidth = 1280;  // set this value to the desired width of your window
        graphics.PreferredBackBufferHeight = 720;   // set this value to the desired height of your window
        graphics.ApplyChanges();

        base.Initialize();
    }

    protected override void LoadContent()
    {
        // Create a new SpriteBatch, which can be used to draw textures.
        spriteBatch = new SpriteBatch(GraphicsDevice);
        game.LoadContent(Content);
        welcome.LoadContent(Content);
    }

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
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed
                || Keyboard.GetState().IsKeyDown(Keys.Escape))
        {
            Exit();
        }

        if (Keyboard.GetState().IsKeyDown(Keys.F8))
        {
            graphics.IsFullScreen = !graphics.IsFullScreen;
            graphics.ApplyChanges();
        }

        if (currentMode == MODE.GAME)
        {
            game.Update(gameTime);
        }
        else if (currentMode == MODE.WELCOME)
        {
            welcome.Update(gameTime);
        }

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);

        spriteBatch.Begin();

        if (currentMode == MODE.GAME)
        {
            game.Draw(gameTime, spriteBatch);
        }
        else if (currentMode == MODE.WELCOME)
        {
            welcome.Draw(gameTime, spriteBatch);
        }
        spriteBatch.End();

        base.Draw(gameTime);
    }
}
