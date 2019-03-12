
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class ScreensManager : Game
{
    GraphicsDeviceManager graphics;
    SpriteBatch spriteBatch;

    GameMain game;
    WelcomeScreen welcomeScr;
    LoadingScreen loadingScr;
    CreditsScreen creditsScr;
    ConfigScreen configScr;
    HelpScreen helpScr;
    EndScreen endScr;


    public enum MODE { LOADING, WELCOME, GAME, CREDITS, CONFIG, HELP, END };
    public MODE currentMode { get; set; }

    public ScreensManager()
    {
        graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";

        game = new GameMain(1280, 720);
        welcomeScr = new WelcomeScreen(this);
        loadingScr = new LoadingScreen(this);
        creditsScr = new CreditsScreen(this);
        configScr = new ConfigScreen(this);
        helpScr = new HelpScreen(this);
        endScr = new EndScreen(this);

        currentMode = MODE.LOADING;
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
        welcomeScr.LoadContent(Content);
        loadingScr.LoadContent(Content);
        creditsScr.LoadContent(Content);
        configScr.LoadContent(Content);
        helpScr.LoadContent(Content);
        endScr.LoadContent(Content);
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

        switch(currentMode)
        {
            case MODE.GAME: game.Update(gameTime); break;
            case MODE.WELCOME: welcomeScr.Update(gameTime); break;
            case MODE.LOADING: loadingScr.Update(gameTime); break;
            case MODE.CREDITS: creditsScr.Update(gameTime); break;
            case MODE.CONFIG: configScr.Update(gameTime); break;
            case MODE.HELP: helpScr.Update(gameTime); break;
            case MODE.END: endScr.Update(gameTime); break;
        }

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);

        spriteBatch.Begin();

        switch (currentMode)
        {
            case MODE.GAME: game.Draw(gameTime, spriteBatch); break;
            case MODE.WELCOME: welcomeScr.Draw(gameTime, spriteBatch); break;
            case MODE.LOADING: loadingScr.Draw(gameTime, spriteBatch); break;
            case MODE.CREDITS: creditsScr.Draw(gameTime, spriteBatch); break;
            case MODE.CONFIG: configScr.Draw(gameTime, spriteBatch); break;
            case MODE.HELP: helpScr.Draw(gameTime, spriteBatch); break;
            case MODE.END: endScr.Draw(gameTime, spriteBatch); break;
        }

        spriteBatch.End();
        base.Draw(gameTime);
    }
}
