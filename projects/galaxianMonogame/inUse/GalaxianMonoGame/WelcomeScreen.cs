using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class WelcomeScreen
{
    GraphicsDeviceManager graphics;
    ContentManager content;

    private SpriteFont font;
    private ScreensManager manager;

    public WelcomeScreen(ScreensManager manager)
    {
        this.manager = manager;
    }

    public void LoadContent(ContentManager Content)
    {
        font = Content.Load<SpriteFont>("Joystix");
    }

    public void Update(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.D1))
        {
            manager.currentMode = ScreensManager.MODE.GAME;
        }
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString(font, "1.- Play", new Vector2(100, 100), Color.White);
    }
}
