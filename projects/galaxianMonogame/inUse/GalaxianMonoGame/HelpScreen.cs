// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 023m,12-Mar-19   Nacho: Adapted to Monogame
// 009, 21-Feb-19   Nacho: Empty skeleton

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class HelpScreen
{
    GraphicsDeviceManager graphics;
    ContentManager content;

    private SpriteFont font;
    private ScreensManager manager;

    public HelpScreen(ScreensManager manager)
    {
        this.manager = manager;
    }

    public void LoadContent(ContentManager Content)
    {
        font = Content.Load<SpriteFont>("Joystix");
    }

    public void Update(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.R))
        {
            manager.currentMode = ScreensManager.MODE.WELCOME;
        }
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString(font, "Help soon available. Hit R to Return", new Vector2(100, 100), Color.White);
    }
}

