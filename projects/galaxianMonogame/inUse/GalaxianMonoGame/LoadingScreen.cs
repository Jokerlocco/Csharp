// Galaxian SDL

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 023m,12-Mar-19   Nacho: Adapted to Monogame
// 012, 21-Feb-19   Enrique, Gonzalo: Login screen for 3 seconds
// 009, 21-Feb-19   Nacho: Empty skeleton

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class LoadingScreen
{
    GraphicsDeviceManager graphics;
    ContentManager content;

    protected Texture2D loadingImage;
    private ScreensManager manager;
    private System.DateTime start;

    public LoadingScreen(ScreensManager manager)
    {
        this.manager = manager;
        start = System.DateTime.Now;
    }

    public void LoadContent(ContentManager Content)
    {
        loadingImage = Content.Load<Texture2D>("galaxian_logo");
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
        spriteBatch.Draw(loadingImage, new Vector2(300, 300), Color.White);
    }
}
