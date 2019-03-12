// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 023m,12-Mar-19   Nacho: Adapted to Monogame
// 008, 04-Ene-19   Nacho: Extracted from class GalaxianSDL, only one text
// 007, 06-Dic-18   S. Ruescas: Created End Screen

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class EndScreen
{
    GraphicsDeviceManager graphics;
    ContentManager content;

    private SpriteFont font;
    private ScreensManager manager;
    private System.DateTime start;

    public EndScreen(ScreensManager manager)
    {
        this.manager = manager;
    }

    public void LoadContent(ContentManager Content)
    {
        font = Content.Load<SpriteFont>("Joystix");
    }

    public void Update(GameTime gameTime)
    {
        System.TimeSpan elapsed = System.DateTime.Now - start;
        if (elapsed.TotalMilliseconds > 2000)
        {
            manager.currentMode = ScreensManager.MODE.WELCOME;
        }
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString(font, "Game over!", 
            new Vector2(400, 300), Color.White);
    }

    public void ResetTimer()
    {
        start = System.DateTime.Now;
    }
}
